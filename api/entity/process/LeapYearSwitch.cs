using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 闰年切换
    /// </summary>
    public class LeapYearSwitch
    {
        string beforTxperimentTime;//实验前时间
        string afterTxperimentTime;//实验后时间
        int result;//结论

        public string BeforTxperimentTime
        {
            get
            {
                return beforTxperimentTime;
            }

            set
            {
                beforTxperimentTime = value;
            }
        }

        public string AfterTxperimentTime
        {
            get
            {
                return afterTxperimentTime;
            }

            set
            {
                afterTxperimentTime = value;
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

        public LeapYearSwitch(string beforTxperimentTime, string afterTxperimentTime, int result)
        {
            this.beforTxperimentTime = beforTxperimentTime;
            this.afterTxperimentTime = afterTxperimentTime;
            this.result = result;
        }
    }
}
