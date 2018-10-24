using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity.process;

namespace api.common
{
    public interface IBaseApi
    {
        /// <summary>
        /// 基本误差数据写入函数
        /// </summary>
        /// <returns></returns>
        int sendBasicError(BasicErrorEntity entity);
    }
}
