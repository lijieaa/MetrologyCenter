using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 潜动试验（单相表、三相表）
    /// </summary>
    public class ShuntRunningTest
    {
        string powDirection;//功率方向
        string voltageLoad;//电压负载
        string loadCurrent;//电流负载
        float theoryShuntTimes;//潜动理论耗时
        float realShuntTimes;//潜动实际耗时
        float shuntPulses;//潜动脉冲数
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

        public string VoltageLoad
        {
            get
            {
                return voltageLoad;
            }

            set
            {
                voltageLoad = value;
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

        public float TheoryShuntTimes
        {
            get
            {
                return theoryShuntTimes;
            }

            set
            {
                theoryShuntTimes = value;
            }
        }

        public float RealShuntTimes
        {
            get
            {
                return realShuntTimes;
            }

            set
            {
                realShuntTimes = value;
            }
        }

        public float ShuntPulses
        {
            get
            {
                return shuntPulses;
            }

            set
            {
                shuntPulses = value;
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

        public ShuntRunningTest(string powDirection, string voltageLoad, string loadCurrent, float theoryShuntTimes, float realShuntTimes, float shuntPulses, int result)
        {
            this.powDirection = powDirection;
            this.voltageLoad = voltageLoad;
            this.loadCurrent = loadCurrent;
            this.theoryShuntTimes = theoryShuntTimes;
            this.realShuntTimes = realShuntTimes;
            this.shuntPulses = shuntPulses;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}_"
                , this.powDirection
                , this.loadCurrent
                ,this.voltageLoad
                );
        }
    }
}
