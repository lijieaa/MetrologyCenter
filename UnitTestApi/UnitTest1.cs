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
        private MqttApi api;

        [TestInitialize]
        public void init()
        {
            api = new MqttApi("jay","127.0.0.1",1883,"aaaaa");
        }
        [TestMethod]
        public void sendBasicError()
        {
            BasicErrorEntity be = new BasicErrorEntity("0","0","0","0","0","0","0","0","0","0","0","aa", "bb", "cc", 0, 0, 0, 0, 0, 0, 0, 0);
            api.sendBasicError(be);
        }
        [TestCleanup]
        public void clear()
        {
            api.Disconnect();
        }
    }
}
