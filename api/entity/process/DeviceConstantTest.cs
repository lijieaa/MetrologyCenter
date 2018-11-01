using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 电能表常数试验（单相表、三相表）
    /// </summary>
    public class DeviceConstantTest
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        string ratePeriod; //费率
        int theoryPulse;//理论脉冲数
        int realPulse;//实际脉冲数
        float beginDegree;//起始度数
        float endDegree;//结束度数
        float runningDif;//走字差值
        float stdDegree;//标准版度数
        float eqError;//电量误差
        float errorMin;//误差下限
        float errorMax;//误差上限
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

        public string PowFactor
        {
            get
            {
                return powFactor;
            }

            set
            {
                powFactor = value;
            }
        }

        public string RatePeriod
        {
            get
            {
                return ratePeriod;
            }

            set
            {
                ratePeriod = value;
            }
        }

        public int TheoryPulse
        {
            get
            {
                return theoryPulse;
            }

            set
            {
                theoryPulse = value;
            }
        }

        public int RealPulse
        {
            get
            {
                return realPulse;
            }

            set
            {
                realPulse = value;
            }
        }

        public float BeginDegree
        {
            get
            {
                return beginDegree;
            }

            set
            {
                beginDegree = value;
            }
        }

        public float EndDegree
        {
            get
            {
                return endDegree;
            }

            set
            {
                endDegree = value;
            }
        }

        public float RunningDif
        {
            get
            {
                return runningDif;
            }

            set
            {
                runningDif = value;
            }
        }

        public float StdDegree
        {
            get
            {
                return stdDegree;
            }

            set
            {
                stdDegree = value;
            }
        }

        public float EqError
        {
            get
            {
                return eqError;
            }

            set
            {
                eqError = value;
            }
        }

        public float ErrorMin
        {
            get
            {
                return errorMin;
            }

            set
            {
                errorMin = value;
            }
        }

        public float ErrorMax
        {
            get
            {
                return errorMax;
            }

            set
            {
                errorMax = value;
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

        public DeviceConstantTest(string powDirection, string loadCurrent, string powFactor, string ratePeriod, int theoryPulse, int realPulse, float beginDegree, float endDegree, float runningDif, float stdDegree, float eqError, float errorMin, float errorMax, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.ratePeriod = ratePeriod;
            this.theoryPulse = theoryPulse;
            this.realPulse = realPulse;
            this.beginDegree = beginDegree;
            this.endDegree = endDegree;
            this.runningDif = runningDif;
            this.stdDegree = stdDegree;
            this.eqError = eqError;
            this.errorMin = errorMin;
            this.errorMax = errorMax;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}_"
                , this.powDirection
                , this.loadCurrent
                , this.powFactor
                ,this.ratePeriod
                );
        }
    }
}
