using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 电流过载试验
    /// </summary>
    public class CurrentOverLoad
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float overloadTimes;//过载时间;秒
        float recoveryWaitTimes;//恢复等待时间
        float firstError1;//第一次误差
        float firstError2;//第一次误差
        float firstError3;//第一次误差
        float firstError4;//第一次误差
        float firstError5;//第一次误差
        float secdError1;//第二次误差
        float secdError2;//第二次误差
        float secdError3;//第二次误差
        float secdError4;//第二次误差
        float secdError5;//第二次误差
        float avgErr;//误差平均值
        float intConvertError;//误差化整值
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

        public float OverloadTimes
        {
            get
            {
                return overloadTimes;
            }

            set
            {
                overloadTimes = value;
            }
        }

        public float RecoveryWaitTimes
        {
            get
            {
                return recoveryWaitTimes;
            }

            set
            {
                recoveryWaitTimes = value;
            }
        }

        public float FirstError1
        {
            get
            {
                return firstError1;
            }

            set
            {
                firstError1 = value;
            }
        }

        public float FirstError2
        {
            get
            {
                return firstError2;
            }

            set
            {
                firstError2 = value;
            }
        }

        public float FirstError3
        {
            get
            {
                return firstError3;
            }

            set
            {
                firstError3 = value;
            }
        }

        public float FirstError4
        {
            get
            {
                return firstError4;
            }

            set
            {
                firstError4 = value;
            }
        }

        public float FirstError5
        {
            get
            {
                return firstError5;
            }

            set
            {
                firstError5 = value;
            }
        }

        public float SecdError1
        {
            get
            {
                return secdError1;
            }

            set
            {
                secdError1 = value;
            }
        }

        public float SecdError2
        {
            get
            {
                return secdError2;
            }

            set
            {
                secdError2 = value;
            }
        }

        public float SecdError3
        {
            get
            {
                return secdError3;
            }

            set
            {
                secdError3 = value;
            }
        }

        public float SecdError4
        {
            get
            {
                return secdError4;
            }

            set
            {
                secdError4 = value;
            }
        }

        public float SecdError5
        {
            get
            {
                return secdError5;
            }

            set
            {
                secdError5 = value;
            }
        }

        public float AvgErr
        {
            get
            {
                return avgErr;
            }

            set
            {
                avgErr = value;
            }
        }

        public float IntConvertError
        {
            get
            {
                return intConvertError;
            }

            set
            {
                intConvertError = value;
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

        public CurrentOverLoad(string powDirection, string loadCurrent, string powFactor, float overloadTimes, float recoveryWaitTimes, float firstError1, float firstError2, float firstError3, float firstError4, float firstError5, float secdError1, float secdError2, float secdError3, float secdError4, float secdError5, float avgErr, float intConvertError, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.overloadTimes = overloadTimes;
            this.recoveryWaitTimes = recoveryWaitTimes;
            this.firstError1 = firstError1;
            this.firstError2 = firstError2;
            this.firstError3 = firstError3;
            this.firstError4 = firstError4;
            this.firstError5 = firstError5;
            this.secdError1 = secdError1;
            this.secdError2 = secdError2;
            this.secdError3 = secdError3;
            this.secdError4 = secdError4;
            this.secdError5 = secdError5;
            this.avgErr = avgErr;
            this.intConvertError = intConvertError;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}_"
                , this.powDirection
                , this.loadCurrent
                , this.powFactor
                );
        }
    }
}
