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
    }
}
