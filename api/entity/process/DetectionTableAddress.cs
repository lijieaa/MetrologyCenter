using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 探测表地址
    /// </summary>
    public class DetectionTableAddress
    {
        string tableAddress;//表地址
        int result;//结论

        public string TableAddress
        {
            get
            {
                return tableAddress;
            }

            set
            {
                tableAddress = value;
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

        public DetectionTableAddress(string tableAddress, int result)
        {
            this.tableAddress = tableAddress;
            this.result = result;
        }
    }
}
