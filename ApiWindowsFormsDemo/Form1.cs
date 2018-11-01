using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using api.mqtt;
using api.entity.process;
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

            try
            {
                api.Connect(clientId);
            }
            catch (Exception)
            {

                Console.WriteLine("连接服务器失败！");
            }
            

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


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            fThread.Abort();
            api.Disconnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08","02","1","1","00","000","115","009","001","002", "3530001000101287123919");
            BasicErrorEntity basicError = new BasicErrorEntity("P+", "合元0.5L", "0.2Ib", 1.2f, 1.3f, 1.4f, 1.5f, 1.6f, 1.7f, 1,1);
            api.sendBasicError(head, basicError);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 常数试验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "009", "003", "004", "3530001000101287103416");
            DeviceConstantTest deviceConstantTest = new DeviceConstantTest("P+", "合元", "0.004Ib","",0,0,1.1f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,1);
            api.sendDeviceConstantTest(head, deviceConstantTest);
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "009", "005", "005", "3530001000101287188895");
            StartTest startTest = new StartTest("P+", "合元115",1.0f,1.0f,1.0f,1);
            api.sendStartTest(head, startTest);
        }
    }
}
