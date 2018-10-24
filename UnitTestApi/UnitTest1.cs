using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using api.mqtt;
using api.common;
using entity.process;

namespace UnitTestApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sendBasicError()
        {
            IBaseApi api = new MqttApi();
            BasicErrorEntity be = new BasicErrorEntity("0","0","0","0","0","0","0","0","0","0","0","aa", "bb", "cc", 0, 0, 0, 0, 0, 0, 0, 0);
            api.sendBasicError(be);
        }
    }
}
