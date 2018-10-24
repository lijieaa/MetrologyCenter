using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.common;
using entity.process;
using Newtonsoft.Json;

namespace api.mqtt
{
    public class MqttApi : IBaseApi
    {
        /// <summary>
        /// 基本误差数据写入函数
        /// </summary>
        /// <param name="entity">基本误差实体</param>
        /// <returns></returns>
        int IBaseApi.sendBasicError(BasicErrorEntity entity)
        {
            //throw new NotImplementedException();
            string json = JsonConvert.SerializeObject(entity);
            Console.WriteLine(json);
            return 0;
        }
    }
}
