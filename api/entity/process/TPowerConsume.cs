using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 功率消耗（三相表）
    /// </summary>
    public class TPowerConsume
    {
        float aVolActPower;//A相电压回路有功功率
        float bVolActPower;//B相电压回路有功功率
        float cVolActPower;//C相电压回路有功功率
        float aVolInsPower;//A相电压回路视在功率
        float bVolInsPower;//B相电压回路视在功率
        float cVolInsPower;//C相电压回路视在功率
        float aCurActPower;//A相电流回路有功功率
        float bCurActPower;//B相电流回路有功功率
        float cCurActPower;//C相电流回路有功功率
        float aCurInsPower;//A相电流回路视在功率
        float bCurInsPower;//B相电流回路视在功率
        float cCurInsPower;//C相电流回路视在功率
        int result;//结论

        public float AVolActPower
        {
            get
            {
                return aVolActPower;
            }

            set
            {
                aVolActPower = value;
            }
        }

        public float BVolActPower
        {
            get
            {
                return bVolActPower;
            }

            set
            {
                bVolActPower = value;
            }
        }

        public float CVolActPower
        {
            get
            {
                return cVolActPower;
            }

            set
            {
                cVolActPower = value;
            }
        }

        public float AVolInsPower
        {
            get
            {
                return aVolInsPower;
            }

            set
            {
                aVolInsPower = value;
            }
        }

        public float BVolInsPower
        {
            get
            {
                return bVolInsPower;
            }

            set
            {
                bVolInsPower = value;
            }
        }

        public float CVolInsPower
        {
            get
            {
                return cVolInsPower;
            }

            set
            {
                cVolInsPower = value;
            }
        }

        public float ACurActPower
        {
            get
            {
                return aCurActPower;
            }

            set
            {
                aCurActPower = value;
            }
        }

        public float BCurActPower
        {
            get
            {
                return bCurActPower;
            }

            set
            {
                bCurActPower = value;
            }
        }

        public float CCurActPower
        {
            get
            {
                return cCurActPower;
            }

            set
            {
                cCurActPower = value;
            }
        }

        public float ACurInsPower
        {
            get
            {
                return aCurInsPower;
            }

            set
            {
                aCurInsPower = value;
            }
        }

        public float BCurInsPower
        {
            get
            {
                return bCurInsPower;
            }

            set
            {
                bCurInsPower = value;
            }
        }

        public float CCurInsPower
        {
            get
            {
                return cCurInsPower;
            }

            set
            {
                cCurInsPower = value;
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

        public TPowerConsume(float aVolActPower, float bVolActPower, float cVolActPower, float aVolInsPower, float bVolInsPower, float cVolInsPower, float aCurActPower, float bCurActPower, float cCurActPower, float aCurInsPower, float bCurInsPower, float cCurInsPower, int result)
        {
            this.aVolActPower = aVolActPower;
            this.bVolActPower = bVolActPower;
            this.cVolActPower = cVolActPower;
            this.aVolInsPower = aVolInsPower;
            this.bVolInsPower = bVolInsPower;
            this.cVolInsPower = cVolInsPower;
            this.aCurActPower = aCurActPower;
            this.bCurActPower = bCurActPower;
            this.cCurActPower = cCurActPower;
            this.aCurInsPower = aCurInsPower;
            this.bCurInsPower = bCurInsPower;
            this.cCurInsPower = cCurInsPower;
            this.result = result;
        }
    }
}
