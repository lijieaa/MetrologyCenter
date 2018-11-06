using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 需量周期误差（单相表、三相表）
    /// </summary>
    public class NeedQperiodError
    {
        string demandPeriodTime;//需量周期时间
        string slipTime;//滑差时间
        float stdDemandReading;// 标准表需量示值
        float testerDemandReading;// 被测表需量示值
        float demandReadingErr;// 需量示值误差
        float demandPeriodErr;// 需量周期误差
        float demandPeriodErrLimit;// 需量周期误差限值
        float stdTableDemand;//标准表需量
        float demandClearResult;//需量清零结果
        int result;//结论

        public string DemandPeriodTime
        {
            get
            {
                return demandPeriodTime;
            }

            set
            {
                demandPeriodTime = value;
            }
        }

        public string SlipTime
        {
            get
            {
                return slipTime;
            }

            set
            {
                slipTime = value;
            }
        }

        public float StdDemandReading
        {
            get
            {
                return stdDemandReading;
            }

            set
            {
                stdDemandReading = value;
            }
        }

        public float TesterDemandReading
        {
            get
            {
                return testerDemandReading;
            }

            set
            {
                testerDemandReading = value;
            }
        }

        public float DemandReadingErr
        {
            get
            {
                return demandReadingErr;
            }

            set
            {
                demandReadingErr = value;
            }
        }

        public float DemandPeriodErr
        {
            get
            {
                return demandPeriodErr;
            }

            set
            {
                demandPeriodErr = value;
            }
        }

        public float DemandPeriodErrLimit
        {
            get
            {
                return demandPeriodErrLimit;
            }

            set
            {
                demandPeriodErrLimit = value;
            }
        }

        public float StdTableDemand
        {
            get
            {
                return stdTableDemand;
            }

            set
            {
                stdTableDemand = value;
            }
        }

        public float DemandClearResult
        {
            get
            {
                return demandClearResult;
            }

            set
            {
                demandClearResult = value;
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

        public NeedQperiodError(string demandPeriodTime, string slipTime, float stdDemandReading, float testerDemandReading, float demandReadingErr, float demandPeriodErr, float demandPeriodErrLimit, float stdTableDemand, float demandClearResult, int result)
        {
            this.demandPeriodTime = demandPeriodTime;
            this.slipTime = slipTime;
            this.stdDemandReading = stdDemandReading;
            this.testerDemandReading = testerDemandReading;
            this.demandReadingErr = demandReadingErr;
            this.demandPeriodErr = demandPeriodErr;
            this.demandPeriodErrLimit = demandPeriodErrLimit;
            this.stdTableDemand = stdTableDemand;
            this.demandClearResult = demandClearResult;
            this.result = result;
        }
    }
}
