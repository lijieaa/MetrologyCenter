using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.common;
using entity.process;
using Newtonsoft.Json;
using uPLibrary.Networking.M2Mqtt;
using System.Net;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace api.mqtt
{
    public class MqttApi : IBaseApi
    {
        private MqttClient client;
        private string topic;
        public  MqttApi(string clientId,string host,int port,string topic)
        {
            this.client = new MqttClient(IPAddress.Parse(host),port,false,null);

            string guid = Guid.NewGuid().ToString();

            this.client.Connect(clientId+"@"+ guid);

            this.topic = topic;

        }

        /// <summary>
        /// 推送数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ushort publish(string data)
        {
            return client.Publish(this.topic, Encoding.UTF8.GetBytes(data), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Disconnect()
        {
            this.client.Disconnect();
        }
        /// <summary>
        /// 基本误差数据写入函数
        /// </summary>
        /// <param name="entity">基本误差实体</param>
        /// <returns></returns>
        public int sendBasicError(BasicErrorEntity entity)
        {
            string json = JsonConvert.SerializeObject(entity);
            this.publish(json);
            return 0;
        }
    }
}
