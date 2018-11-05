using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 交流电压试验（单相表、三相表）（耐压）
    /// </summary>
    public class ACVoltTest
    {
        float voltTestValue;//耐压值;伏
        float testObj;//检定项目
        float realTestTime;//测试时长;秒
        float meterLeakageCur;//表漏电流
        float voltagetesterLeakageCur;//耐压仪漏电流
        float freq;//频率
        int result;//结论

        public float VoltTestValue
        {
            get
            {
                return voltTestValue;
            }

            set
            {
                voltTestValue = value;
            }
        }

        public float TestObj
        {
            get
            {
                return testObj;
            }

            set
            {
                testObj = value;
            }
        }

        public float RealTestTime
        {
            get
            {
                return realTestTime;
            }

            set
            {
                realTestTime = value;
            }
        }

        public float MeterLeakageCur
        {
            get
            {
                return meterLeakageCur;
            }

            set
            {
                meterLeakageCur = value;
            }
        }

        public float VoltagetesterLeakageCur
        {
            get
            {
                return voltagetesterLeakageCur;
            }

            set
            {
                voltagetesterLeakageCur = value;
            }
        }

        public float Freq
        {
            get
            {
                return freq;
            }

            set
            {
                freq = value;
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

        public ACVoltTest(float voltTestValue, float testObj, float realTestTime, float meterLeakageCur, float voltagetesterLeakageCur, float freq, int result)
        {
            this.voltTestValue = voltTestValue;
            this.testObj = testObj;
            this.realTestTime = realTestTime;
            this.meterLeakageCur = meterLeakageCur;
            this.voltagetesterLeakageCur = voltagetesterLeakageCur;
            this.freq = freq;
            this.result = result;
        }
    }
}
