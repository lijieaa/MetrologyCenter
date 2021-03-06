﻿using System;
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
        /// <summary>
        /// 基本误差试验（单相表、三相表）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// 起动试验（单相表、三相表）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "009", "004", "005", "3530001000101287188895");
            StartTest startTest = new StartTest("P+", "合元115",1.0f,1.0f,1.0f,1);
            api.sendStartTest(head, startTest);
        }
        /// <summary>
        /// 潜动试验（单相表、三相表）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "009", "005", "006", "3530001000101287188895");
            ShuntRunningTest shuntRunningTest = new ShuntRunningTest("P+", "合元115","", 1.0f, 1.0f, 1.0f, 1);
            api.sendShuntRunningTest(head, shuntRunningTest);
        }
        /// <summary>
        /// 误差变差实验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "011", "006", "3530001000101287188895");
            ErrorVariationTest errorVariationTest = new ErrorVariationTest("P+", "合元115", "", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendErrorVariationTest(head, errorVariationTest);
        }

        /// <summary>
        /// 误差一致性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "012", "006", "3530001000101287188895");
            ErrorConsistencyTest errorConsistencyTest = new ErrorConsistencyTest("P+", "合元115", "", 1.4f, 1.2f, 1.3f, 1);
            api.sendErrorConsistencyTest(head, errorConsistencyTest);
        }

        /// <summary>
        /// 负载电流升降变差试验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "013", "006", "3530001000101287188895");
            CurrentLoadUpdownVarErr currentLoadUpdownVarErr = new CurrentLoadUpdownVarErr("P+", "合元115", "", "", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendCurrentLoadUpdownVarErr(head, currentLoadUpdownVarErr);
        }
        /// <summary>
        /// 电流过载试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">电流过载试验属性信息</param>
        /// <returns></returns>
        private void button9_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "024", "006", "3530001000101287188895");
            CurrentOverLoad currentOverLoad = new CurrentOverLoad("P+", "合元115", "", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendCurrentOverLoad(head, currentOverLoad);
        }
        /// <summary>
        /// 计数器示值组合误差--没有找到编号ID
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">计数器示值组合误差属性信息</param>
        /// <returns></returns>
        private void button10_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }

        /// <summary>
        /// 日计时误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="dayTimingError">日计时误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        private void button12_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "006", "006", "3530001000101287188895");
            DayTimingError dayTimingError = new DayTimingError(1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,  1);
            api.sendDayTimingError(head, dayTimingError);
        }
        /// <summary>
        /// 功率消耗（单相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="oPowerConsume">功率消耗（单相表）属性信息</param>
        /// <returns></returns>
        private void button13_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "009", "006", "3530001000101287188895");
            OPowerConsume oPowerConsume = new OPowerConsume( 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendOPowerConsume(head, oPowerConsume);
        }
        /// <summary>
        /// 功率消耗（三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="tPowerConsume">功率消耗（三相表）属性信息</param>
        /// <returns></returns>
        private void button14_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "009", "006", "3530001000101287188895");
            TPowerConsume tPowerConsume = new TPowerConsume(1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f,1);
            api.sendTPowerConsume(head, tPowerConsume);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }
        /// <summary>
        /// 时段投切误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="periodFlingCutError">交流电压试验（单相表、三相表）（耐压）属性信息</param>
        /// <returns></returns>
        private void button16_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "014", "006", "3530001000101287188895");
            PeriodFlingCutError periodFlingCutError = new PeriodFlingCutError("a", "b", "c", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendPeriodFlingCutError(head,periodFlingCutError);
        }
        /// <summary>
        /// 走字试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="runningTest">走字试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        private void button17_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "026", "006", "3530001000101287188895");
            RunningTest runningTest = new RunningTest(1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendRunningTest(head, runningTest);
        }
        /// <summary>
        /// 需量周期误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">需量周期误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        private void button18_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "016", "006", "3530001000101287188895");
            NeedQperiodError needQperiodError = new NeedQperiodError("a", "b", 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 1);
            api.sendNeedQperiodError(head, needQperiodError);
        }
        /// <summary>
        /// 拉合闸试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">拉合闸试验属性信息</param>
        /// <returns></returns>
        private void button19_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }
        /// <summary>
        /// 对时功能
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="syncTimeTest">对时功能属性信息</param>
        /// <returns></returns>
        private void button22_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "029", "006", "3530001000101287188895");
            SyncTimeTest syncTimeTest = new SyncTimeTest("a", "b", 1);
            api.sendSyncTimeTest(head, syncTimeTest);
        }
        /// <summary>
        /// 读通信地址
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="readAddr">读通信地址属性信息</param>
        /// <returns></returns>
        private void button23_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "030", "006", "3530001000101287188895");
            ReadAddr readAddr = new ReadAddr("a", 1);
            api.sendReadAddr(head, readAddr);
        }
        /// <summary>
        /// 身份认证
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="iDAuthentication">身份认证属性信息</param>
        /// <returns></returns>
        private void button25_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "033", "006", "3530001000101287188895");
            IDAuthentication iDAuthentication = new IDAuthentication(1.1f, 1);
            api.sendIDAuthentication(head, iDAuthentication);
        }
        /// <summary>
        /// 探测表地址
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="detectionTableAddress">探测表地址属性信息</param>
        /// <returns></returns>
        private void button27_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "031", "006", "3530001000101287188895");
            DetectionTableAddress detectionTableAddress = new DetectionTableAddress("a", 1);
            api.sendDetectionTableAddress(head, detectionTableAddress);
        }
        /// <summary>
        /// 广播校时
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="broadcastCheckTime">广播校时属性信息</param>
        /// <returns></returns>
        private void button28_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "037", "006", "3530001000101287188895");
            BroadcastCheckTime broadcastCheckTime = new BroadcastCheckTime("a","b",1);
            api.sendBroadcastCheckTime(head, broadcastCheckTime);
        }
        /// <summary>
        /// 闰年切换
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="leapYearSwitch">闰年切换属性信息</param>
        /// <returns></returns>
        private void button29_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "043", "006", "3530001000101287188895");
            LeapYearSwitch leapYearSwitch = new LeapYearSwitch("a", "b", 1);
            api.sendLeapYearSwitch(head, leapYearSwitch);
        }
        /// <summary>
        /// 标准偏差
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="standardError">标准偏差属性信息</param>
        /// <returns></returns>
        private void button32_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "038", "006", "3530001000101287188895");
            StandardError standardError = new StandardError(1, 2,3,4,5,6,7, 1);
            api.sendStandardError(head, standardError);
        }
        /// <summary>
        /// 所有只有一个结论的结构体：外观检查 功率消耗 耐压实验 载波通信试验  拉合闸实验 密钥下装 电量清零（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="standardError">所有只有一个结论的结构体：外观检查 功率消耗 耐压实验 载波通信试验  拉合闸实验 密钥下装 电量清零（单相表、三相表）属性信息</param>
        /// <returns></returns>
        private void button33_Click(object sender, EventArgs e)
        {
            DetectHead head = new DetectHead("08", "02", "1", "1", "00", "000", "115", "007", "001", "006", "3530001000101287188895");
            ResultStruct resultStruct = new ResultStruct(1);
            api.sendResultStruct(head, resultStruct);
        }
    }
}
