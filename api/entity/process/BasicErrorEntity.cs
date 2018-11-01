using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.entity.common;
using api.entity.process;

namespace api.entity.process
{
    /// <summary>
    /// 基本误差试验（单相表、三相表）
    /// </summary>
    public class BasicErrorEntity
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float error1;//误差1
        float error2;//误差2
        float error3;//误差3
        float error4;//误差4
        float error5;//误差5
        float errAvg;//平均误差
        float errtoInt;//误差化整                                                                  //结论:8
        int result;//结论(0:合格，1:不合格)

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

        public float Error1
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

        public float Error2
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

        public float Error3
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

        public float Error4
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

        public float Error5
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

        public float ErrAvg
        {
            get
            {
                return errAvg;
            }

            set
            {
                errAvg = value;
            }
        }

        public float ErrtoInt
        {
            get
            {
                return errtoInt;
            }

            set
            {
                errtoInt = value;
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

        public BasicErrorEntity(string powDirection, string loadCurrent, string powFactor, float error1, float error2, float error3, float error4, float error5, float errAvg, float errtoInt, int result)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.error1 = error1;
            this.error2 = error2;
            this.error3 = error3;
            this.error4 = error4;
            this.error5 = error5;
            this.errAvg = errAvg;
            this.errtoInt = errtoInt;
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
