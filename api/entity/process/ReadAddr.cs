using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 读通信地址
    /// </summary>
   public class ReadAddr
    {
        string commAddr;//通信地址
        int result;//结论

        public ReadAddr(string commAddr, int result)
        {
            this.commAddr = commAddr;
            this.result = result;
        }

        public string CommAddr
        {
            get
            {
                return commAddr;
            }

            set
            {
                commAddr = value;
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
