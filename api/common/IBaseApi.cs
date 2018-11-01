using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.entity.process;

namespace api.common
{
    public interface IBaseApi
    {
        /// <summary>
        /// 基本误差试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="basicError">基本误差试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendBasicError(DetectHead head,BasicErrorEntity basicError);

        /// <summary>
        /// 剩余电能量递减准确度
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="surplusEQDescend">剩余电能量递减准确度属性信息</param>
        /// <returns></returns>
        int sendSurplusEQDescend(DetectHead head,SurplusEQDescendEntity surplusEQDescend);

        /// <summary>
        /// 电能表常数试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="deviceConstantTest">电能表常数试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendDeviceConstantTest(DetectHead head, DeviceConstantTest deviceConstantTest);

        /// <summary>
        /// 起动试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="startTest">起动试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendStartTest(DetectHead head, StartTest startTest);
    }
}
