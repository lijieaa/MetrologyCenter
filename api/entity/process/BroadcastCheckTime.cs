using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 广播校时
    /// </summary>
    public class BroadcastCheckTime
    {
        string beforCheckTime;//校时前时间
        string afterCheckTime;//校时后时间
        int result;//结论

        public string BeforCheckTime
        {
            get
            {
                return beforCheckTime;
            }

            set
            {
                beforCheckTime = value;
            }
        }

        public string AfterCheckTime
        {
            get
            {
                return afterCheckTime;
            }

            set
            {
                afterCheckTime = value;
            }
        }

        public int Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public BroadcastCheckTime(string beforCheckTime, string afterCheckTime, int result)
        {
            this.beforCheckTime = beforCheckTime;
            this.afterCheckTime = afterCheckTime;
            this.result = result;
        }
    }
}
