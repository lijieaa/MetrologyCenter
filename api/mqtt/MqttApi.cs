using System;
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



        /// <summary>
        /// 功率消耗（三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="tPowerConsume">功率消耗（三相表）属性信息</param>
        /// <returns></returns>
        public int sendTPowerConsume(DetectHead head, TPowerConsume tPowerConsume)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //A相电压回路有功功率
            string AVolActPower = head.TypeId + "_1" + "@" + tPowerConsume.AVolActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AVolActPower), this.qosLevel, this.retain);


            //B相电压回路有功功率
            string BVolActPower = head.TypeId + "_2" + "@" + tPowerConsume.BVolActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BVolActPower), this.qosLevel, this.retain);


            //C相电压回路有功功率
            string CVolActPower = head.TypeId + "_3" + "@" + tPowerConsume.CVolActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CVolActPower), this.qosLevel, this.retain);

            //A相电压回路视在功率
            string AVolInsPower = head.TypeId + "_4" + "@" + tPowerConsume.AVolInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AVolInsPower), this.qosLevel, this.retain);

            //B相电压回路视在功率
            string BVolInsPower = head.TypeId + "_5" + "@" + tPowerConsume.BVolInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BVolInsPower), this.qosLevel, this.retain);

            //C相电压回路视在功率
            string CVolInsPower = head.TypeId + "_6" + "@" + tPowerConsume.CVolInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CVolInsPower), this.qosLevel, this.retain);


            //A相电流回路有功功率
            string ACurActPower = head.TypeId + "_7" + "@" + tPowerConsume.ACurActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ACurActPower), this.qosLevel, this.retain);




            //B相电流回路有功功率
            string BCurActPower = head.TypeId + "_8" + "@" + tPowerConsume.BCurActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BCurActPower), this.qosLevel, this.retain);


            //C相电流回路有功功率
            string CCurActPower = head.TypeId + "_9" + "@" + tPowerConsume.CCurActPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CCurActPower), this.qosLevel, this.retain);


            //A相电流回路视在功率
            string ACurInsPower = head.TypeId + "_10" + "@" + tPowerConsume.ACurInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ACurInsPower), this.qosLevel, this.retain);


            //B相电流回路视在功率
            string BCurInsPower = head.TypeId + "_11" + "@" + tPowerConsume.BCurInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BCurInsPower), this.qosLevel, this.retain);

            //C相电流回路视在功率
            string CCurInsPower = head.TypeId + "_12" + "@" + tPowerConsume.CCurInsPower;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CCurInsPower), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_13" + "@" + tPowerConsume.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }

        public int sendACVoltTest(DetectHead head, ACVoltTest aCVoltTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //耐压值;伏
            string VoltTestValue = head.TypeId + "_1" + "@" + aCVoltTest.VoltTestValue;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(VoltTestValue), this.qosLevel, this.retain);


            //检定项目
            string TestObj = head.TypeId + "_2" + "@" + aCVoltTest.TestObj;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TestObj), this.qosLevel, this.retain);


            //测试时长;秒
            string RealTestTime = head.TypeId + "_3" + "@" + aCVoltTest.RealTestTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RealTestTime), this.qosLevel, this.retain);

            //表漏电流
            string MeterLeakageCur = head.TypeId + "_4" + "@" + aCVoltTest.MeterLeakageCur;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(MeterLeakageCur), this.qosLevel, this.retain);

            //耐压仪漏电流
            string VoltagetesterLeakageCur = head.TypeId + "_5" + "@" + aCVoltTest.VoltagetesterLeakageCur;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(VoltagetesterLeakageCur), this.qosLevel, this.retain);

            //频率
            string Freq = head.TypeId + "_6" + "@" + aCVoltTest.Freq;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Freq), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_7" + "@" + aCVoltTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 时段投切误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="periodFlingCutError">交流电压试验（单相表、三相表）（耐压）属性信息</param>
        /// <returns></returns>
        public int sendPeriodFlingCutError(DetectHead head, PeriodFlingCutError periodFlingCutError)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            
            //投切时间
            string FlingcutTime = head.TypeId + "_1" + "@" + periodFlingCutError.FlingcutTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FlingcutTime), this.qosLevel, this.retain);


            //实际投切时间
            string RealFlingcutTime = head.TypeId + "_2" + "@" + periodFlingCutError.RealFlingcutTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RealFlingcutTime), this.qosLevel, this.retain);

            //当前费率时间
            string CurrentRateTime = head.TypeId + "_3" + "@" + periodFlingCutError.CurrentRateTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CurrentRateTime), this.qosLevel, this.retain);

            //示值误差
            string ReadingError = head.TypeId + "_4" + "@" + periodFlingCutError.ReadingError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ReadingError), this.qosLevel, this.retain);

            //组合误差
            string CombineError = head.TypeId + "_5" + "@" + periodFlingCutError.CombineError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CombineError), this.qosLevel, this.retain);

            //投切误差
            string FlingcutError = head.TypeId + "_6" + "@" + periodFlingCutError.FlingcutError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FlingcutError), this.qosLevel, this.retain);

            //费率号
            string RateId = head.TypeId + "_7" + "@" + periodFlingCutError.RateId;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RateId), this.qosLevel, this.retain);

            //投切方式
            string FlingcutWay = head.TypeId + "_8" + "@" + periodFlingCutError.FlingcutWay;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(FlingcutWay), this.qosLevel, this.retain);


            //投切方式
            string Result = head.TypeId + "_9" + "@" + periodFlingCutError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 走字试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="runningTest">走字试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendRunningTest(DetectHead head, RunningTest runningTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);



            //起动示值
            string StartReading = head.TypeId + "_1" + "@" + runningTest.StartReading;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StartReading), this.qosLevel, this.retain);


            //结束示值
            string EndReading = head.TypeId + "_2" + "@" + runningTest.EndReading;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EndReading), this.qosLevel, this.retain);

            //示值误差
            string ReadingError = head.TypeId + "_3" + "@" + runningTest.ReadingError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ReadingError), this.qosLevel, this.retain);

            //走字误差值
            string RunningError = head.TypeId + "_4" + "@" + runningTest.RunningError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RunningError), this.qosLevel, this.retain);

            //起始度数
            string BeginDegree = head.TypeId + "_5" + "@" + runningTest.BeginDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BeginDegree), this.qosLevel, this.retain);

            //结束度数
            string EndDegree = head.TypeId + "_6" + "@" + runningTest.EndDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EndDegree), this.qosLevel, this.retain);

            //走字度数
            string RunningDegree = head.TypeId + "_7" + "@" + runningTest.RunningDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RunningDegree), this.qosLevel, this.retain);

            //走字方式
            string RunningWay = head.TypeId + "_8" + "@" + runningTest.RunningWay;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(RunningWay), this.qosLevel, this.retain);


            //脉冲数
            string PulseNum = head.TypeId + "_9" + "@" + runningTest.PulseNum;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(PulseNum), this.qosLevel, this.retain);


            //标准表度数
            string StdTableDegree = head.TypeId + "_10" + "@" + runningTest.StdTableDegree;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StdTableDegree), this.qosLevel, this.retain);

            //电量误差
            string EqError = head.TypeId + "_11" + "@" + runningTest.EqError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EqError), this.qosLevel, this.retain);

            //误差上限
            string ErrorMax = head.TypeId + "_12" + "@" + runningTest.ErrorMax;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrorMax), this.qosLevel, this.retain);


            //误差上限
            string ErrorMin = head.TypeId + "_13" + "@" + runningTest.ErrorMin;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(ErrorMin), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_14" + "@" + runningTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 需量周期误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">需量周期误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        public int sendNeedQperiodError(DetectHead head, NeedQperiodError needQperiodError)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);



            //需量周期时间
            string DemandPeriodTime = head.TypeId + "_1" + "@" + needQperiodError.DemandPeriodTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DemandPeriodTime), this.qosLevel, this.retain);


            //滑差时间
            string SlipTime = head.TypeId + "_2" + "@" + needQperiodError.SlipTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SlipTime), this.qosLevel, this.retain);

            // 标准表需量示值
            string StdDemandReading = head.TypeId + "_3" + "@" + needQperiodError.StdDemandReading;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StdDemandReading), this.qosLevel, this.retain);

            //被测表需量示值
            string TesterDemandReading = head.TypeId + "_4" + "@" + needQperiodError.TesterDemandReading;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TesterDemandReading), this.qosLevel, this.retain);

            //需量示值误差
            string DemandReadingErr = head.TypeId + "_5" + "@" + needQperiodError.DemandReadingErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DemandReadingErr), this.qosLevel, this.retain);

            //需量周期误差
            string DemandPeriodErr = head.TypeId + "_6" + "@" + needQperiodError.DemandPeriodErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DemandPeriodErr), this.qosLevel, this.retain);

            //需量周期误差限值
            string DemandPeriodErrLimit = head.TypeId + "_7" + "@" + needQperiodError.DemandPeriodErrLimit;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DemandPeriodErrLimit), this.qosLevel, this.retain);

            //标准表需量
            string StdTableDemand = head.TypeId + "_8" + "@" + needQperiodError.StdTableDemand;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StdTableDemand), this.qosLevel, this.retain);


            //需量清零结果
            string DemandClearResult = head.TypeId + "_9" + "@" + needQperiodError.DemandClearResult;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(DemandClearResult), this.qosLevel, this.retain);



            //结论
            string Result = head.TypeId + "_10" + "@" + needQperiodError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 拉合闸试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">拉合闸试验属性信息</param>
        /// <returns></returns>
        public int sendSwitchTest(DetectHead head, SwitchTest switchTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);



            //拉闸前状态
            string SwitchOutBeforeStatus = head.TypeId + "_1" + "@" + switchTest.SwitchOutBeforeStatus;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SwitchOutBeforeStatus), this.qosLevel, this.retain);


            //拉闸后状态
            string SwitchOutAfterStatus = head.TypeId + "_2" + "@" + switchTest.SwitchOutAfterStatus;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SwitchOutAfterStatus), this.qosLevel, this.retain);

            // 合闸前状态
            string SwitchOnBeforeStatus = head.TypeId + "_3" + "@" + switchTest.SwitchOnBeforeStatus;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SwitchOnBeforeStatus), this.qosLevel, this.retain);

            //合闸后状态
            string SwitchOnAfterStatus = head.TypeId + "_4" + "@" + switchTest.SwitchOnAfterStatus;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SwitchOnAfterStatus), this.qosLevel, this.retain);

            //Result
            string Result = head.TypeId + "_5" + "@" + switchTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 对时功能
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="syncTimeTest">对时功能属性信息</param>
        /// <returns></returns>
        public int sendSyncTimeTest(DetectHead head, SyncTimeTest syncTimeTest)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);



            //对时前电能表时间
            string SyncBefore = head.TypeId + "_1" + "@" + syncTimeTest.SyncBefore;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SyncBefore), this.qosLevel, this.retain);


            //对时后电能表时间
            string SyncAfter = head.TypeId + "_2" + "@" + syncTimeTest.SyncAfter;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(SyncAfter), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_3" + "@" + syncTimeTest.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
        /// <summary>
        /// 读通信地址
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="readAddr">读通信地址属性信息</param>
        /// <returns></returns>
        public int sendReadAddr(DetectHead head, ReadAddr readAddr)
        {

            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //通信地址
            string CommAddr = head.TypeId + "_1" + "@" + readAddr.CommAddr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(CommAddr), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_2" + "@" + readAddr.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 身份认证
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="iDAuthentication">身份认证属性信息</param>
        /// <returns></returns>
        public int sendIDAuthentication(DetectHead head, IDAuthentication iDAuthentication)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //ESAM系列号
            string EsamSerialNumber = head.TypeId + "_1" + "@" + iDAuthentication.EsamSerialNumber;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(EsamSerialNumber), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_2" + "@" + iDAuthentication.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }

        /// <summary>
        /// 探测表地址
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="detectionTableAddress">探测表地址属性信息</param>
        /// <returns></returns>
        public int sendDetectionTableAddress(DetectHead head, DetectionTableAddress detectionTableAddress)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //表地址
            string TableAddress = head.TypeId + "_1" + "@" + detectionTableAddress.TableAddress;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(TableAddress), this.qosLevel, this.retain);


            //结论
            string Result = head.TypeId + "_2" + "@" + detectionTableAddress.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 广播校时
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="broadcastCheckTime">广播校时属性信息</param>
        /// <returns></returns>
        public int sendBroadcastCheckTime(DetectHead head, BroadcastCheckTime broadcastCheckTime)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //校时前时间
            string BeforCheckTime = head.TypeId + "_1" + "@" + broadcastCheckTime.BeforCheckTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BeforCheckTime), this.qosLevel, this.retain);


            //校时后时间
            string AfterCheckTime = head.TypeId + "_2" + "@" + broadcastCheckTime.AfterCheckTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AfterCheckTime), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_3" + "@" + broadcastCheckTime.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }
        /// <summary>
        /// 闰年切换
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="leapYearSwitch">闰年切换属性信息</param>
        /// <returns></returns>
        public int sendLeapYearSwitch(DetectHead head, LeapYearSwitch leapYearSwitch)
        {
            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);


            //实验前时间
            string BeforTxperimentTime = head.TypeId + "_1" + "@" + leapYearSwitch.BeforTxperimentTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(BeforTxperimentTime), this.qosLevel, this.retain);


            //实验后时间
            string AfterTxperimentTime = head.TypeId + "_2" + "@" + leapYearSwitch.AfterTxperimentTime;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AfterTxperimentTime), this.qosLevel, this.retain);

            //结论
            string Result = head.TypeId + "_3" + "@" + leapYearSwitch.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);

            return 0;
        }

        /// <summary>
        /// 标准偏差
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="standardError">标准偏差属性信息</param>
        /// <returns></returns>
        public int sendStandardError(DetectHead head, StandardError standardError)
        {

            //表位与表条码绑定
            string barcode = head.MeterId + "_" + "1001" + "@" + head.BarCode;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(barcode), this.qosLevel, this.retain);



            //误差1
            string Error1 = head.TypeId + "_1" + "@" + standardError.Error1;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error1), this.qosLevel, this.retain);


            //误差2
            string Error2 = head.TypeId + "_2" + "@" + standardError.Error2;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error2), this.qosLevel, this.retain);

            // 误差3
            string Error3 = head.TypeId + "_3" + "@" + standardError.Error3;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error3), this.qosLevel, this.retain);

            //误差4
            string Error4 = head.TypeId + "_4" + "@" + standardError.Error4;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error4), this.qosLevel, this.retain);

            //误差5
            string Error5 = head.TypeId + "_5" + "@" + standardError.Error5;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Error5), this.qosLevel, this.retain);

            //平均误差
            string AvgError = head.TypeId + "_6" + "@" + standardError.AvgError;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(AvgError), this.qosLevel, this.retain);

            ///标准偏差
            string StandardError = head.TypeId + "_7" + "@" + standardError.StandardErr;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(StandardError), this.qosLevel, this.retain);

        
            //结论
            string Result = head.TypeId + "_8" + "@" + standardError.Result;
            this.Publish(VERIFICATION_PROCESS_TOP, Encoding.UTF8.GetBytes(Result), this.qosLevel, this.retain);


            return 0;
        }
    }
}
