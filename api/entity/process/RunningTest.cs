using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 走字试验（单相表、三相表）
    /// </summary>
   public class RunningTest
    {
        float startReading;//起动示值
        float endReading;//结束示值
        float readingError;//示值误差
        float runningError;//走字误差值
        float beginDegree;//起始度数
        float endDegree;//结束度数
        float runningDegree;//走字度数
        float runningWay;//走字方式
        float pulseNum;//脉冲数
        float stdTableDegree;//标准表度数
        float eqError;//电量误差
        float errorMax;//误差上限
        float errorMin;//误差下限
        int result;//结论

        public float StartReading
        {
            get
            {
                return startReading;
            }

            set
            {
                startReading = value;
            }
        }

        public float EndReading
        {
            get
            {
                return endReading;
            }

            set
            {
                endReading = value;
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

        public float RunningError
        {
            get
            {
                return runningError;
            }

            set
            {
                runningError = value;
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

        public float RunningDegree
        {
            get
            {
                return runningDegree;
            }

            set
            {
                runningDegree = value;
            }
        }

        public float RunningWay
        {
            get
            {
                return runningWay;
            }

            set
            {
                runningWay = value;
            }
        }

        public float PulseNum
        {
            get
            {
                return pulseNum;
            }

            set
            {
                pulseNum = value;
            }
        }

        public float StdTableDegree
        {
            get
            {
                return stdTableDegree;
            }

            set
            {
                stdTableDegree = value;
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

        public RunningTest(float startReading, float endReading, float readingError, float runningError, float beginDegree, float endDegree, float runningDegree, float runningWay, float pulseNum, float stdTableDegree, float eqError, float errorMax, float errorMin, int result)
        {
            this.startReading = startReading;
            this.endReading = endReading;
            this.readingError = readingError;
            this.runningError = runningError;
            this.beginDegree = beginDegree;
            this.endDegree = endDegree;
            this.runningDegree = runningDegree;
            this.runningWay = runningWay;
            this.pulseNum = pulseNum;
            this.stdTableDegree = stdTableDegree;
            this.eqError = eqError;
            this.errorMax = errorMax;
            this.errorMin = errorMin;
            this.result = result;
        }
    }
}
