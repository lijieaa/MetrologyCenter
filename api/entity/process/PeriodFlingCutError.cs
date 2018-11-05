using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 时段投切误差（单相表、三相表）
    /// </summary>
    public class PeriodFlingCutError
    {
        string flingcutTime;//投切时间
        string realFlingcutTime;//实际投切时间
        string currentRateTime;//当前费率时间
        float readingError;//示值误差
        float combineError;//组合误差
        float flingcutError;//投切误差
        float rateId;//费率号
        float flingcutWay;//投切方式
        int result;//结论

        public string FlingcutTime
        {
            get
            {
                return flingcutTime;
            }

            set
            {
                flingcutTime = value;
            }
        }

        public string RealFlingcutTime
        {
            get
            {
                return realFlingcutTime;
            }

            set
            {
                realFlingcutTime = value;
            }
        }

        public string CurrentRateTime
        {
            get
            {
                return currentRateTime;
            }

            set
            {
                currentRateTime = value;
            }
        }

        public float ReadingError
        {
            get
            {
                return readingError;
            }

            set
            {
                readingError = value;
            }
        }

        public float CombineError
        {
            get
            {
                return combineError;
            }

            set
            {
                combineError = value;
            }
        }

        public float FlingcutError
        {
            get
            {
                return flingcutError;
            }

            set
            {
                flingcutError = value;
            }
        }

        public float RateId
        {
            get
            {
                return rateId;
            }

            set
            {
                rateId = value;
            }
        }

        public float FlingcutWay
        {
            get
            {
                return flingcutWay;
            }

            set
            {
                flingcutWay = value;
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

        public PeriodFlingCutError(string flingcutTime, string realFlingcutTime, string currentRateTime, float readingError, float combineError, float flingcutError, float rateId, float flingcutWay, int result)
        {
            this.flingcutTime = flingcutTime;
            this.realFlingcutTime = realFlingcutTime;
            this.currentRateTime = currentRateTime;
            this.readingError = readingError;
            this.combineError = combineError;
            this.flingcutError = flingcutError;
            this.rateId = rateId;
            this.flingcutWay = flingcutWay;
            this.result = result;
        }
    }
}
