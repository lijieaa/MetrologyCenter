using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 功率消耗（单相表）
    /// </summary>
    public class OPowerConsume
    {
        float volActPower;//电压回路有功功率
        float volInsPower;//电压回路视在功率
        float curActPower;//电流回路有功功率
        float curInsPower;//电流回路视在功率
        int result;//结论

        public float VolActPower
        {
            get
            {
                return volActPower;
            }

            set
            {
                volActPower = value;
            }
        }

        public float VolInsPower
        {
            get
            {
                return volInsPower;
            }

            set
            {
                volInsPower = value;
            }
        }

        public float CurActPower
        {
            get
            {
                return curActPower;
            }

            set
            {
                curActPower = value;
            }
        }

        public float CurInsPower
        {
            get
            {
                return curInsPower;
            }

            set
            {
                curInsPower = value;
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

        public OPowerConsume(float volActPower, float volInsPower, float curActPower, float curInsPower, int result)
        {
            this.volActPower = volActPower;
            this.volInsPower = volInsPower;
            this.curActPower = curActPower;
            this.curInsPower = curInsPower;
            this.result = result;
        }
    }
}
