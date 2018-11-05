﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.common;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using System.Net;
using uPLibrary.Networking.M2Mqtt.Messages;
using api.entity.process;

namespace api.mqtt
{
    public class MqttApi : MqttClient,IBaseApi
    {
        //private MqttClient client;

        //private string topic;
        //private string clientId;

        private const string VERIFICATION_PROCESS_TOP = "mc/verification_process";
        private byte qosLevel=MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
        private bool retain= false;

        public MqttApi(string brokerHostName) : base(brokerHostName)
        {

        }


        /*public  MqttApi(string clientId,string host,int port,string topic)
        {
            this.client = new MqttClient(IPAddress.Parse(host),port,false,null);

            this.clientId = clientId;

            this.client.Connect(clientId+"@"+ Guid.NewGuid().ToString());

            this.topic = topic;

        }*/

        /// <summary>
        /// 推送数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
       /* private ushort publish(string data)
        {
            return client.Publish(this.topic, Encoding.UTF8.GetBytes(data), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }*/
        /// <summary>
        /// 关闭连接
        /// </summary>
        /*public void Disconnect()
        {
            this.client.Disconnect();
        }*/
        /// <summary>
        /// 基本误差试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="basicError">基本误差试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendBasicError(DetectHead head, BasicErrorEntity basicError)
        {
            //表位与表条码绑定
            string barcode = head.MeterId +"_"+"1001"+ "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //发送误差1
            string error1 = head.TypeId+"_"+basicError.ToString() +"1"+"@"+ basicError.Error1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(error1), this.qosLevel, this.retain);


            //发送误差2
            string error2 = head.TypeId + "_" + basicError.ToString() + "2" + "@" + basicError.Error2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(error2), this.qosLevel, this.retain);


            //发送误差3
            string error3 = head.TypeId + "_" + basicError.ToString() + "3" + "@" + basicError.Error3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(error3), this.qosLevel, this.retain);

            //发送误差4
            string error4 = head.TypeId + "_" + basicError.ToString() + "4" + "@" + basicError.Error4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(error4), this.qosLevel, this.retain);

            //发送误差5
            string error5 = head.TypeId + "_" + basicError.ToString() + "5" + "@" + basicError.Error5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(error5), this.qosLevel, this.retain);

            //平均误差
            string ErrAvg = head.TypeId + "_" + basicError.ToString() + "6" + "@" + basicError.ErrAvg;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrAvg), this.qosLevel, this.retain);


            //误差化整数
            string ErrtoInt = head.TypeId + "_" + basicError.ToString() + "7" + "@" + basicError.ErrtoInt;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrtoInt), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_" + basicError.ToString() + "8" + "@" + basicError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);
            
            return 0;
        }

        

        /// <summary>
        ///没有找到对应编号
        /// </summary>
        /// <param name="head"></param>
        /// <param name="surplusEQDescend"></param>
        /// <returns></returns>
        public int sendSurplusEQDescend(DetectHead head, SurplusEQDescendEntity surplusEQDescend)
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 电能表常数试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="deviceConstantTest">电能表常数试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendDeviceConstantTest(DetectHead head, DeviceConstantTest deviceConstantTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //理论脉冲数
            string TheoryPulse = head.TypeId + "_" + deviceConstantTest.ToString() + "1" + "@" + deviceConstantTest.TheoryPulse;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TheoryPulse), this.qosLevel, this.retain);


            //实际脉冲数
            string RealPulse = head.TypeId + "_" + deviceConstantTest.ToString() + "2" + "@" + deviceConstantTest.RealPulse;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RealPulse), this.qosLevel, this.retain);


            //起始度数
            string BeginDegree = head.TypeId + "_" + deviceConstantTest.ToString() + "3" + "@" + deviceConstantTest.BeginDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BeginDegree), this.qosLevel, this.retain);

            //结束度数
            string EndDegree = head.TypeId + "_" + deviceConstantTest.ToString() + "4" + "@" + deviceConstantTest.EndDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EndDegree), this.qosLevel, this.retain);

            //走字差值
            string RunningDif = head.TypeId + "_" + deviceConstantTest.ToString() + "5" + "@" + deviceConstantTest.RunningDif;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RunningDif), this.qosLevel, this.retain);

            //标准版度数
            string StdDegree = head.TypeId + "_" + deviceConstantTest.ToString() + "6" + "@" + deviceConstantTest.StdDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StdDegree), this.qosLevel, this.retain);


            //电量误差
            string EqError = head.TypeId + "_" + deviceConstantTest.ToString() + "7" + "@" + deviceConstantTest.EqError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EqError), this.qosLevel, this.retain);

            //误差下限
            string ErrorMin = head.TypeId + "_" + deviceConstantTest.ToString() + "8" + "@" + deviceConstantTest.ErrorMin;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrorMin), this.qosLevel, this.retain);


            //误差上限
            string ErrorMax = head.TypeId + "_" + deviceConstantTest.ToString() + "9" + "@" + deviceConstantTest.ErrorMax;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrorMax), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_" + deviceConstantTest.ToString() + "10" + "@" + deviceConstantTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 起动试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="startTest">起动试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendStartTest(DetectHead head, StartTest startTest)
        {

            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //起动理论时间
            string TheoryStartTimes = head.TypeId + "_" + startTest.ToString() + "1" + "@" + startTest.TheoryStartTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TheoryStartTimes), this.qosLevel, this.retain);


            //起动实际耗时
            string RealStartTimes = head.TypeId + "_" + startTest.ToString() + "2" + "@" + startTest.RealStartTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RealStartTimes), this.qosLevel, this.retain);


            //起动脉冲数
            string StartPulses = head.TypeId + "_" + startTest.ToString() + "3" + "@" + startTest.StartPulses;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StartPulses), this.qosLevel, this.retain);

            

            //结论
            string Result = head.TypeId + "_" + startTest.ToString() + "4" + "@" + startTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 潜动试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="shuntRunningTest">潜动试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendShuntRunningTest(DetectHead head, ShuntRunningTest shuntRunningTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //潜动理论耗时
            string TheoryShuntTimes = head.TypeId + "_" + shuntRunningTest.ToString() + "1" + "@" + shuntRunningTest.TheoryShuntTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TheoryShuntTimes), this.qosLevel, this.retain);


            //潜动实际耗时
            string RealShuntTimes = head.TypeId + "_" + shuntRunningTest.ToString() + "2" + "@" + shuntRunningTest.RealShuntTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RealShuntTimes), this.qosLevel, this.retain);


            //潜动脉冲数
            string ShuntPulses = head.TypeId + "_" + shuntRunningTest.ToString() + "3" + "@" + shuntRunningTest.ShuntPulses;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ShuntPulses), this.qosLevel, this.retain);



            //结论
            string Result = head.TypeId + "_" + shuntRunningTest.ToString() + "4" + "@" + shuntRunningTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }

        /// <summary>
        /// 误差变差试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="errorVariationTest">误差变差试验属性信息</param>
        /// <returns></returns>
        public int sendErrorVariationTest(DetectHead head, ErrorVariationTest errorVariationTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //一次误差1
            string OnceError1 = head.TypeId + "_" + errorVariationTest.ToString() + "1" + "@" + errorVariationTest.OnceError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(OnceError1), this.qosLevel, this.retain);


            //一次误差2
            string OnceError2 = head.TypeId + "_" + errorVariationTest.ToString() + "2" + "@" + errorVariationTest.OnceError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(OnceError2), this.qosLevel, this.retain);


            //一次误差3
            string OnceError3 = head.TypeId + "_" + errorVariationTest.ToString() + "3" + "@" + errorVariationTest.OnceError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(OnceError3), this.qosLevel, this.retain);

            //一次误差4
            string OnceError4 = head.TypeId + "_" + errorVariationTest.ToString() + "4" + "@" + errorVariationTest.OnceError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(OnceError4), this.qosLevel, this.retain);

            //一次误差5
            string RunningDif = head.TypeId + "_" + errorVariationTest.ToString() + "5" + "@" + errorVariationTest.OnceError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RunningDif), this.qosLevel, this.retain);

            //一次误差平均值
            string AvgOnceError = head.TypeId + "_" + errorVariationTest.ToString() + "6" + "@" + errorVariationTest.AvgOnceError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgOnceError), this.qosLevel, this.retain);


            //一次误差化整值
            string IntOnceError = head.TypeId + "_" + errorVariationTest.ToString() + "7" + "@" + errorVariationTest.IntOnceError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntOnceError), this.qosLevel, this.retain);




            //二次误差1
            string TwiceError1 = head.TypeId + "_" + errorVariationTest.ToString() + "8" + "@" + errorVariationTest.TwiceError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TwiceError1), this.qosLevel, this.retain);


            //二次误差2
            string TwiceError2 = head.TypeId + "_" + errorVariationTest.ToString() + "9" + "@" + errorVariationTest.TwiceError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TwiceError2), this.qosLevel, this.retain);


            //二次误差3
            string TwiceError3 = head.TypeId + "_" + errorVariationTest.ToString() + "10" + "@" + errorVariationTest.TwiceError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TwiceError3), this.qosLevel, this.retain);

            //二次误差4
            string TwiceError4 = head.TypeId + "_" + errorVariationTest.ToString() + "11" + "@" + errorVariationTest.TwiceError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TwiceError4), this.qosLevel, this.retain);

            //二次误差5
            string TwiceError5 = head.TypeId + "_" + errorVariationTest.ToString() + "12" + "@" + errorVariationTest.TwiceError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TwiceError5), this.qosLevel, this.retain);

            //二次误差平均值
            string AvgTwiceError = head.TypeId + "_" + errorVariationTest.ToString() + "13" + "@" + errorVariationTest.AvgTwiceError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgOnceError), this.qosLevel, this.retain);


            //一次误差化整值
            string IntTwiceError = head.TypeId + "_" + errorVariationTest.ToString() + "14" + "@" + errorVariationTest.IntTwiceError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntTwiceError), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_" + errorVariationTest.ToString() + "15" + "@" + errorVariationTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }

        /// <summary>
        /// 误差一致性试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="errorConsistencyTest">误差一致性试验属性信息</param>
        /// <returns></returns>
        public int sendErrorConsistencyTest(DetectHead head, ErrorConsistencyTest errorConsistencyTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //最大误差
            string MaxError = head.TypeId + "_" + errorConsistencyTest.ToString() + "1" + "@" + errorConsistencyTest.MaxError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(MaxError), this.qosLevel, this.retain);


            //所有表位误差平均值
            string AllAvgError = head.TypeId + "_" + errorConsistencyTest.ToString() + "2" + "@" + errorConsistencyTest.AllAvgError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AllAvgError), this.qosLevel, this.retain);


            //所有表位平均误差化整值
            string AllIntError = head.TypeId + "_" + errorConsistencyTest.ToString() + "3" + "@" + errorConsistencyTest.AllIntError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AllIntError), this.qosLevel, this.retain);



            //结论
            string Result = head.TypeId + "_" + errorConsistencyTest.ToString() + "4" + "@" + errorConsistencyTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }

        /// <summary>
        /// 负载电流升降变差试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentLoadUpdownVarErr">负载电流升降变差试验属性信息</param>
        /// <returns></returns>
        public int sendCurrentLoadUpdownVarErr(DetectHead head, CurrentLoadUpdownVarErr currentLoadUpdownVarErr)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //升方向误差1
            string UpError1 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "1" + "@" + currentLoadUpdownVarErr.UpError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(UpError1), this.qosLevel, this.retain);


            //升方向误差2
            string UpError2 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "2" + "@" + currentLoadUpdownVarErr.UpError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(UpError2), this.qosLevel, this.retain);


            //升方向误差3
            string UpError3 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "3" + "@" + currentLoadUpdownVarErr.UpError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(UpError3), this.qosLevel, this.retain);

            //升方向误差4
            string UpError4 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "4" + "@" + currentLoadUpdownVarErr.UpError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(UpError4), this.qosLevel, this.retain);

            //升方向误差5
            string UpError5 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "5" + "@" + currentLoadUpdownVarErr.UpError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(UpError5), this.qosLevel, this.retain);

            //降方向误差1
            string DownError1 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "6" + "@" + currentLoadUpdownVarErr.DownError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DownError1), this.qosLevel, this.retain);


            //降方向误差2
            string DownError2 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "7" + "@" + currentLoadUpdownVarErr.DownError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DownError2), this.qosLevel, this.retain);




            //降方向误差3
            string DownError3 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "8" + "@" + currentLoadUpdownVarErr.DownError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DownError3), this.qosLevel, this.retain);


            //降方向误差4
            string DownError4 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "9" + "@" + currentLoadUpdownVarErr.DownError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DownError4), this.qosLevel, this.retain);


            //降方向误差5
            string DownError5 = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "10" + "@" + currentLoadUpdownVarErr.DownError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DownError5), this.qosLevel, this.retain);

            //升降方向误差平均值
            string AvgErr = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "11" + "@" + currentLoadUpdownVarErr.AvgErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgErr), this.qosLevel, this.retain);

            //升降方向误差化整值
            string IntAvgErr = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "12" + "@" + currentLoadUpdownVarErr.IntAvgErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntAvgErr), this.qosLevel, this.retain);

            //升降变差
            string VariationErr = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "13" + "@" + currentLoadUpdownVarErr.VariationErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(VariationErr), this.qosLevel, this.retain);


            //升降变差化整值
            string IntVariationErr = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "14" + "@" + currentLoadUpdownVarErr.IntVariationErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntVariationErr), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_" + currentLoadUpdownVarErr.ToString() + "15" + "@" + currentLoadUpdownVarErr.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 电流过载试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">电流过载试验属性信息</param>
        /// <returns></returns>
        public int sendCurrentOverLoad(DetectHead head, CurrentOverLoad currentOverLoad)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //过载时间;秒
            string OverloadTimes = head.TypeId + "_" + currentOverLoad.ToString() + "1" + "@" + currentOverLoad.OverloadTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(OverloadTimes), this.qosLevel, this.retain);


            //恢复等待时间
            string RecoveryWaitTimes = head.TypeId + "_" + currentOverLoad.ToString() + "2" + "@" + currentOverLoad.RecoveryWaitTimes;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RecoveryWaitTimes), this.qosLevel, this.retain);


            //第一次误差1
            string FirstError1 = head.TypeId + "_" + currentOverLoad.ToString() + "3" + "@" + currentOverLoad.FirstError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FirstError1), this.qosLevel, this.retain);

            //第一次误差2
            string FirstError2 = head.TypeId + "_" + currentOverLoad.ToString() + "4" + "@" + currentOverLoad.FirstError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FirstError2), this.qosLevel, this.retain);

            //第一次误差3
            string FirstError3 = head.TypeId + "_" + currentOverLoad.ToString() + "5" + "@" + currentOverLoad.FirstError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FirstError3), this.qosLevel, this.retain);

            //第一次误差4
            string FirstError4 = head.TypeId + "_" + currentOverLoad.ToString() + "6" + "@" + currentOverLoad.FirstError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FirstError4), this.qosLevel, this.retain);


            //第一次误差5
            string FirstError5 = head.TypeId + "_" + currentOverLoad.ToString() + "7" + "@" + currentOverLoad.FirstError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FirstError5), this.qosLevel, this.retain);




            //第二次误差1
            string SecdError1 = head.TypeId + "_" + currentOverLoad.ToString() + "8" + "@" + currentOverLoad.SecdError1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SecdError1), this.qosLevel, this.retain);


            //第二次误差2
            string SecdError2 = head.TypeId + "_" + currentOverLoad.ToString() + "9" + "@" + currentOverLoad.SecdError2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SecdError2), this.qosLevel, this.retain);


            //第二次误差3
            string SecdError3 = head.TypeId + "_" + currentOverLoad.ToString() + "10" + "@" + currentOverLoad.SecdError3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SecdError3), this.qosLevel, this.retain);

            //第二次误差4
            string SecdError4 = head.TypeId + "_" + currentOverLoad.ToString() + "11" + "@" + currentOverLoad.SecdError4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SecdError4), this.qosLevel, this.retain);

            //第二次误差5
            string SecdError5 = head.TypeId + "_" + currentOverLoad.ToString() + "12" + "@" + currentOverLoad.SecdError5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SecdError5), this.qosLevel, this.retain);

            //误差平均值
            string AvgErr = head.TypeId + "_" + currentOverLoad.ToString() + "13" + "@" + currentOverLoad.AvgErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgErr), this.qosLevel, this.retain);


            //误差化整值
            string IntConvertError = head.TypeId + "_" + currentOverLoad.ToString() + "14" + "@" + currentOverLoad.IntConvertError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntConvertError), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_" + currentOverLoad.ToString() + "15" + "@" + currentOverLoad.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 计数器示值组合误差
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">计数器示值组合误差属性信息</param>
        /// <returns></returns>
        public int sendCounterValueCombineError(DetectHead head, CounterValueCombineError counterValueCombineError)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //总
            string TotalValue = head.TypeId + "_" + counterValueCombineError.ToString() + "1" + "@" + counterValueCombineError.TotalValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TotalValue), this.qosLevel, this.retain);


            //峰
            string PeakValue = head.TypeId + "_" + counterValueCombineError.ToString() + "2" + "@" + counterValueCombineError.PeakValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(PeakValue), this.qosLevel, this.retain);


            //平
            string ShoulderValue = head.TypeId + "_" + counterValueCombineError.ToString() + "3" + "@" + counterValueCombineError.ShoulderValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ShoulderValue), this.qosLevel, this.retain);

            //谷
            string ValleyValue = head.TypeId + "_" + counterValueCombineError.ToString() + "4" + "@" + counterValueCombineError.ValleyValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ValleyValue), this.qosLevel, this.retain);

            //尖
            string SharpValue = head.TypeId + "_" + counterValueCombineError.ToString() + "5" + "@" + counterValueCombineError.SharpValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SharpValue), this.qosLevel, this.retain);

            //增量1
            string Increment1 = head.TypeId + "_" + counterValueCombineError.ToString() + "6" + "@" + counterValueCombineError.Increment1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Increment1), this.qosLevel, this.retain);


            //增量2
            string Increment2 = head.TypeId + "_" + counterValueCombineError.ToString() + "7" + "@" + counterValueCombineError.Increment2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Increment2), this.qosLevel, this.retain);




            //总增量
            string TotalIncrement = head.TypeId + "_" + counterValueCombineError.ToString() + "8" + "@" + counterValueCombineError.TotalIncrement;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TotalIncrement), this.qosLevel, this.retain);


            //增量差值
            string IncrementError = head.TypeId + "_" + counterValueCombineError.ToString() + "9" + "@" + counterValueCombineError.IncrementError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IncrementError), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_" + counterValueCombineError.ToString() + "10" + "@" + counterValueCombineError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 日计时误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="dayTimingError">日计时误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendDayTimingError(DetectHead head, DayTimingError dayTimingError)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //误差1
            string Error1 = head.TypeId + "_1" + "@" + dayTimingError.Error1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error1), this.qosLevel, this.retain);


            //误差2
            string Error2 = head.TypeId + "_2" + "@" + dayTimingError.Error2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error2), this.qosLevel, this.retain);


            //误差3
            string Error3 = head.TypeId + "_3" + "@" + dayTimingError.Error3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error3), this.qosLevel, this.retain);

            //误差4
            string Error4 = head.TypeId + "_4" + "@" + dayTimingError.Error4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error4), this.qosLevel, this.retain);

            //误差5
            string Error5 = head.TypeId + "_5" + "@" + dayTimingError.Error5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error5), this.qosLevel, this.retain);

            //误差6
            string Error6 = head.TypeId + "_6" + "@" + dayTimingError.Error6;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error6), this.qosLevel, this.retain);


            //误差7
            string Error7 = head.TypeId + "_7" + "@" + dayTimingError.Error7;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error7), this.qosLevel, this.retain);




            //误差8
            string Error8 = head.TypeId + "_8" + "@" + dayTimingError.Error8;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error8), this.qosLevel, this.retain);


            //误差9
            string Error9 = head.TypeId + "_9" + "@" + dayTimingError.Error9;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error9), this.qosLevel, this.retain);


            //误差10
            string Error10 = head.TypeId + "_10" + "@" + dayTimingError.Error10;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error10), this.qosLevel, this.retain);


            //平均误差
            string AvgError = head.TypeId + "_11" + "@" + dayTimingError.AvgError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgError), this.qosLevel, this.retain);

            //误差化整值
            string IntConvertError = head.TypeId + "_12" + "@" + dayTimingError.IntConvertError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(IntConvertError), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_13" + "@" + dayTimingError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 功率消耗（单相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="oPowerConsume">功率消耗（单相表）属性信息</param>
        /// <returns></returns>
        public int sendOPowerConsume(DetectHead head, OPowerConsume oPowerConsume)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //电压回路有功功率
            string VolActPower = head.TypeId + "_1" + "@" + oPowerConsume.VolActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(VolActPower), this.qosLevel, this.retain);


            //电压回路视在功率
            string VolInsPower = head.TypeId + "_2" + "@" + oPowerConsume.VolInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(VolInsPower), this.qosLevel, this.retain);


            //电流回路有功功率
            string CurActPower = head.TypeId + "_3" + "@" + oPowerConsume.CurActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CurActPower), this.qosLevel, this.retain);

            //电流回路视在功率
            string CurInsPower = head.TypeId + "_4" + "@" + oPowerConsume.CurInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CurInsPower), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_5" + "@" + oPowerConsume.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
    }
}
