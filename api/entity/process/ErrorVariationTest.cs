using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 误差变差试验
    /// </summary>
    public class ErrorVariationTest
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float onceError1;//一次误差
        float onceError2;//一次误差
        float onceError3;//一次误差
        float onceError4;//一次误差
        float onceError5;//一次误差
        float avgOnceError;//一次误差平均值
        float intOnceError;//一次误差化整值
        float twiceError1;//二次误差
        float twiceError2;//二次误差
        float twiceError3;//二次误差
        float twiceError4;//二次误差
        float twiceError5;//二次误差
        float avgTwiceError;//二次误差平均值
        float intTwiceError;//二次误差化整值
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

        public float OnceError1
        {
            get
            {
                return onceError1;
            }

            set
            {
                onceError1 = value;
            }
        }

        public float OnceError2
        {
            get
            {
                return onceError2;
            }

            set
            {
                onceError2 = value;
            }
        }

        public float OnceError3
        {
            get
            {
                return onceError3;
            }

            set
            {
                onceError3 = value;
            }
        }

        public float OnceError4
        {
            get
            {
                return onceError4;
            }

            set
            {
                onceError4 = value;
            }
        }

        public float OnceError5
        {
            get
            {
                return onceError5;
            }

            set
            {
                onceError5 = value;
            }
        }

        public float AvgOnceError
        {
            get
            {
                return avgOnceError;
            }

            set
            {
                avgOnceError = value;
            }
        }

        public float IntOnceError
        {
            get
            {
                return intOnceError;
            }

            set
            {
                intOnceError = value;
            }
        }

        public float TwiceError1
        {
            get
            {
                return twiceError1;
            }

            set
            {
                twiceError1 = value;
            }
        }

        public float TwiceError2
        {
            get
            {
                return twiceError2;
            }

            set
            {
                twiceError2 = value;
            }
        }

        public float TwiceError3
        {
            get
            {
                return twiceError3;
            }

            set
            {
                twiceError3 = value;
            }
        }

        public float TwiceError4
        {
            get
            {
                return twiceError4;
            }

            set
            {
                twiceError4 = value;
            }
        }

        public float TwiceError5
        {
            get
            {
                return twiceError5;
            }

            set
            {
                twiceError5 = value;
            }
        }

        public float AvgTwiceError
        {
            get
            {
                return avgTwiceError;
            }

            set
            {
                avgTwiceError = value;
            }
        }

        public float IntTwiceError
        {
            get
            {
                return intTwiceError;
            }

            set
            {
                intTwiceError = value;
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

        public ErrorVariationTest(string powDirection, string loadCurrent, string powFactor, float onceError1, float onceError2, float onceError3, float onceError4, float onceError5, float avgOnceError, float intOnceError, float twiceError1, float twiceError2, float twiceError3, float twiceError4, float twiceError5, float avgTwiceError, float intTwiceError, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.onceError1 = onceError1;
            this.onceError2 = onceError2;
            this.onceError3 = onceError3;
            this.onceError4 = onceError4;
            this.onceError5 = onceError5;
            this.avgOnceError = avgOnceError;
            this.intOnceError = intOnceError;
            this.twiceError1 = twiceError1;
            this.twiceError2 = twiceError2;
            this.twiceError3 = twiceError3;
            this.twiceError4 = twiceError4;
            this.twiceError5 = twiceError5;
            this.avgTwiceError = avgTwiceError;
            this.intTwiceError = intTwiceError;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}_"
                , this.powDirection
                , this.loadCurrent
                ,this.powFactor
                );
        }
    }
}
