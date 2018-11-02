using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 计数器示值组合误差
    /// </summary>
    public class CounterValueCombineError
    {
        float totalValue;//总
        float peakValue;//峰
        float shoulderValue;//平
        float valleyValue;//谷
        float sharpValue;//尖
        float increment1;//增量1
        float increment2;//增量1
        float totalIncrement;//总增量
        float incrementError;//增量差值
        int result;//结论

        public float TotalValue
        {
            get
            {
                return totalValue;
            }

            set
            {
                totalValue = value;
            }
        }

        public float PeakValue
        {
            get
            {
                return peakValue;
            }

            set
            {
                peakValue = value;
            }
        }

        public float ShoulderValue
        {
            get
            {
                return shoulderValue;
            }

            set
            {
                shoulderValue = value;
            }
        }

        public float ValleyValue
        {
            get
            {
                return valleyValue;
            }

            set
            {
                valleyValue = value;
            }
        }

        public float SharpValue
        {
            get
            {
                return sharpValue;
            }

            set
            {
                sharpValue = value;
            }
        }

        public float Increment1
        {
            get
            {
                return increment1;
            }

            set
            {
                increment1 = value;
            }
        }

        public float Increment2
        {
            get
            {
                return increment2;
            }

            set
            {
                increment2 = value;
            }
        }

        public float TotalIncrement
        {
            get
            {
                return totalIncrement;
            }

            set
            {
                totalIncrement = value;
            }
        }

        public float IncrementError
        {
            get
            {
                return incrementError;
            }

            set
            {
                incrementError = value;
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

        public CounterValueCombineError(float totalValue, float peakValue, float shoulderValue, float valleyValue, float sharpValue, float increment1, float increment2, float totalIncrement, float incrementError, int result)
        {
            this.totalValue = totalValue;
            this.peakValue = peakValue;
            this.shoulderValue = shoulderValue;
            this.valleyValue = valleyValue;
            this.sharpValue = sharpValue;
            this.increment1 = increment1;
            this.increment2 = increment2;
            this.totalIncrement = totalIncrement;
            this.incrementError = incrementError;
            this.result = result;
        }


    }
}
