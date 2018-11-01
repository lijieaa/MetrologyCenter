using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 负载电流升降变差试验
    /// </summary>
    public class CurrentLoadUpdownVarErr
    {
        string powDirection;//功率方向	
        string iabc;//电流相别
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float upError1;//升方向误差
        float upError2;//升方向误差
        float upError3;//升方向误差
        float upError4;//升方向误差
        float upError5;//升方向误差
        float downError1;//降方向误差
        float downError2;//降方向误差
        float downError3;//降方向误差
        float downError4;//降方向误差
        float downError5;//降方向误差
        float avgErr;//升降方向误差平均值
        float intAvgErr;//升降方向误差化整值
        float variationErr;//升降变差
        float intVariationErr;//升降变差化整值
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

        public string Iabc
        {
            get
            {
                return iabc;
            }

            set
            {
                iabc = value;
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

        public float UpError1
        {
            get
            {
                return upError1;
            }

            set
            {
                upError1 = value;
            }
        }

        public float UpError2
        {
            get
            {
                return upError2;
            }

            set
            {
                upError2 = value;
            }
        }

        public float UpError3
        {
            get
            {
                return upError3;
            }

            set
            {
                upError3 = value;
            }
        }

        public float UpError4
        {
            get
            {
                return upError4;
            }

            set
            {
                upError4 = value;
            }
        }

        public float UpError5
        {
            get
            {
                return upError5;
            }

            set
            {
                upError5 = value;
            }
        }

        public float DownError1
        {
            get
            {
                return downError1;
            }

            set
            {
                downError1 = value;
            }
        }

        public float DownError2
        {
            get
            {
                return downError2;
            }

            set
            {
                downError2 = value;
            }
        }

        public float DownError3
        {
            get
            {
                return downError3;
            }

            set
            {
                downError3 = value;
            }
        }

        public float DownError4
        {
            get
            {
                return downError4;
            }

            set
            {
                downError4 = value;
            }
        }

        public float DownError5
        {
            get
            {
                return downError5;
            }

            set
            {
                downError5 = value;
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

        public float IntAvgErr
        {
            get
            {
                return intAvgErr;
            }

            set
            {
                intAvgErr = value;
            }
        }

        public float VariationErr
        {
            get
            {
                return variationErr;
            }

            set
            {
                variationErr = value;
            }
        }

        public float IntVariationErr
        {
            get
            {
                return intVariationErr;
            }

            set
            {
                intVariationErr = value;
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

        public CurrentLoadUpdownVarErr(string powDirection, string iabc, string loadCurrent, string powFactor, float upError1, float upError2, float upError3, float upError4, float upError5, float downError1, float downError2, float downError3, float downError4, float downError5, float avgErr, float intAvgErr, float variationErr, float intVariationErr, int result)
        {
            this.powDirection = powDirection;
            this.iabc = iabc;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.upError1 = upError1;
            this.upError2 = upError2;
            this.upError3 = upError3;
            this.upError4 = upError4;
            this.upError5 = upError5;
            this.downError1 = downError1;
            this.downError2 = downError2;
            this.downError3 = downError3;
            this.downError4 = downError4;
            this.downError5 = downError5;
            this.avgErr = avgErr;
            this.intAvgErr = intAvgErr;
            this.variationErr = variationErr;
            this.intVariationErr = intVariationErr;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}_"
                , this.powDirection
                , this.loadCurrent
                , this.powFactor
                ,this.iabc
                );
        }
    }
}
