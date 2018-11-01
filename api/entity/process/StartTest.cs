using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 起动试验
    /// </summary>
    public class StartTest
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        float theoryStartTimes;// 起动理论耗时(ss级)
        float realStartTimes;// 起动实际耗时
        float startPulses;//起动脉冲数
        int result;//结论

        public string PowDirection
        {
            get
            {
                return powDirection;
            }

            set
            {
                powDirection = value;
            }
        }

        public string LoadCurrent
        {
            get
            {
                return loadCurrent;
            }

            set
            {
                loadCurrent = value;
            }
        }

        public float TheoryStartTimes
        {
            get
            {
                return theoryStartTimes;
            }

            set
            {
                theoryStartTimes = value;
            }
        }

        public float RealStartTimes
        {
            get
            {
                return realStartTimes;
            }

            set
            {
                realStartTimes = value;
            }
        }

        public float StartPulses
        {
            get
            {
                return startPulses;
            }

            set
            {
                startPulses = value;
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

        public StartTest(string powDirection, string loadCurrent, float theoryStartTimes, float realStartTimes, float startPulses, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.theoryStartTimes = theoryStartTimes;
            this.realStartTimes = realStartTimes;
            this.startPulses = startPulses;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}_"
                , this.powDirection
                , this.loadCurrent
                );
        }
    }
}
