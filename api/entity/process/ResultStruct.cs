using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 检定结论,所有只有一个结论的结构体：外观检查 功率消耗 耐压实验 载波通信试验  拉合闸实验 密钥下装 电量清零（单相表、三相表）
    /// </summary>
    public class ResultStruct
    {
        int result;

        public ResultStruct(int result)
        {
            this.result = result;
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
