using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    public class ErrorConsistencyTest
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float maxError;//最大误差
        float allAvgError;//所有表位误差平均值
        float allIntError;//所有表位平均误差化整值
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

        public float MaxError
        {
            get
            {
                return maxError;
            }

            set
            {
                maxError = value;
            }
        }

        public float AllAvgError
        {
            get
            {
                return allAvgError;
            }

            set
            {
                allAvgError = value;
            }
        }

        public float AllIntError
        {
            get
            {
                return allIntError;
            }

            set
            {
                allIntError = value;
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

        public ErrorConsistencyTest(string powDirection, string loadCurrent, string powFactor, float maxError, float allAvgError, float allIntError, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.maxError = maxError;
            this.allAvgError = allAvgError;
            this.allIntError = allIntError;
            this.result = result;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}_"
                , this.powDirection
                , this.loadCurrent
                , this.powFactor
                );
        }
    }
}
