using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 标准偏差
    /// </summary>
    public class StandardError
    {
        double error1;//误差1
        double error2;//误差2
        double error3;//误差3
        double error4;//误差4
        double error5;//误差5
        double avgError;//平均误差
        double standardErr;//标准偏差
        int result;

        public double Error1
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

        public double Error2
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

        public double Error3
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

        public double Error4
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

        public double Error5
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

        public double AvgError
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

        public double StandardErr
        {
            get
            {
                return standardErr;
            }

            set
            {
                standardErr = value;
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

        public StandardError(double error1, double error2, double error3, double error4, double error5, double avgError, double standardError, int result)
        {
            this.error1 = error1;
            this.error2 = error2;
            this.error3 = error3;
            this.error4 = error4;
            this.error5 = error5;
            this.avgError = avgError;
            this.standardErr = standardError;
            this.result = result;
        }
    }
}
