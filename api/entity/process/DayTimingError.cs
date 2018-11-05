using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 日计时误差
    /// </summary>
   public  class DayTimingError
    {
        float error1;//误差1
        float error2;//误差2
        float error3;//误差3
        float error4;//误差4
        float error5;//误差5
        float error6;//误差6
        float error7;//误差7
        float error8;//误差8
        float error9;//误差9
        float error10;//误差10
        float avgError;//平均误差
        float intConvertError;//误差化整值
        int result;//结论

        public float Error1
        {
            get
            {
                return error1;
            }

            set
            {
                error1 = value;
            }
        }

        public float Error2
        {
            get
            {
                return error2;
            }

            set
            {
                error2 = value;
            }
        }

        public float Error3
        {
            get
            {
                return error3;
            }

            set
            {
                error3 = value;
            }
        }

        public float Error4
        {
            get
            {
                return error4;
            }

            set
            {
                error4 = value;
            }
        }

        public float Error5
        {
            get
            {
                return error5;
            }

            set
            {
                error5 = value;
            }
        }

        public float Error6
        {
            get
            {
                return error6;
            }

            set
            {
                error6 = value;
            }
        }

        public float Error7
        {
            get
            {
                return error7;
            }

            set
            {
                error7 = value;
            }
        }

        public float Error8
        {
            get
            {
                return error8;
            }

            set
            {
                error8 = value;
            }
        }

        public float Error9
        {
            get
            {
                return error9;
            }

            set
            {
                error9 = value;
            }
        }

        public float Error10
        {
            get
            {
                return error10;
            }

            set
            {
                error10 = value;
            }
        }

        public float AvgError
        {
            get
            {
                return avgError;
            }

            set
            {
                avgError = value;
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

        public DayTimingError(float error1, float error2, float error3, float error4, float error5, float error6, float error7, float error8, float error9, float error10, float avgError, float intConvertError, int result)
        {
            this.error1 = error1;
            this.error2 = error2;
            this.error3 = error3;
            this.error4 = error4;
            this.error5 = error5;
            this.error6 = error6;
            this.error7 = error7;
            this.error8 = error8;
            this.error9 = error9;
            this.error10 = error10;
            this.avgError = avgError;
            this.intConvertError = intConvertError;
            this.result = result;
        }
    }
}
