using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using api.mqtt;
using entity.process;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Threading;

namespace ApiWindowsFormsDemo
{
    public partial class Form1 : Form
    {
        private MqttApi api;

        Thread fThread;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            api = new MqttApi("127.0.0.1");
            string clientId = Guid.NewGuid().ToString();
            api.Connect(clientId);
            api.MqttMsgDisconnected += Api_MqttMsgDisconnected;
            api.MqttMsgPublished += Api_MqttMsgPublished;
            api.MqttMsgPublishReceived += Api_MqttMsgPublishReceived;
            api.MqttMsgSubscribed += Api_MqttMsgSubscribed;
            api.MqttMsgUnsubscribed += Api_MqttMsgUnsubscribed;

            api.Subscribe(new string[] { "verification_process" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            
            fThread = new Thread(new ThreadStart(check));
            fThread.Start();

            


        }

        private void check()
        {
            while (true)
            {
                if (!api.IsConnected)
                {
                    Console.WriteLine(api.IsConnected);
                    try
                    {
                        api.Connect(Guid.NewGuid().ToString());
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                    
                }
                
            }
            
        }

        private void Api_MqttMsgUnsubscribed(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgUnsubscribedEventArgs e)
        {
            Console.WriteLine("Api_MqttMsgUnsubscribed");
        }

        private void Api_MqttMsgSubscribed(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgSubscribedEventArgs e)
        {
            Console.WriteLine("Api_MqttMsgSubscribed");
        }

        private void Api_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            Console.WriteLine(Encoding.UTF8.GetString(e.Message));
        }

        private void Api_MqttMsgPublished(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishedEventArgs e)
        {
            Console.WriteLine("Api_MqttMsgPublished");
        }

        private void Api_MqttMsgDisconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Api_MqttMsgDisconnected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicErrorEntity be = new BasicErrorEntity("0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "aa", "bb", "cc", 0, 0, 0, 0, 0, 0, 0, 0);
            api.sendBasicError(be);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fThread.Abort();
            api.Disconnect();
        }
    }
}
