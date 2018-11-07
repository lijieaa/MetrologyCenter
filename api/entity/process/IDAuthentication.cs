using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 身份认证
    /// </summary>
    public class IDAuthentication
    {
        float esamSerialNumber;//ESAM系列号
        int result;//结论

        public IDAuthentication(float esamSerialNumber, int result)
        {
            this.esamSerialNumber = esamSerialNumber;
            this.result = result;
        }

        public float EsamSerialNumber
        {
            get
            {
                return esamSerialNumber;
            }

            set
            {
                esamSerialNumber = value;
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
    }
}
