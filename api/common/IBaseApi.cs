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


        /// <summary>
        /// 潜动试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="shuntRunningTest">潜动试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendShuntRunningTest(DetectHead head, ShuntRunningTest shuntRunningTest);


        /// <summary>
        /// 误差变差试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="errorVariationTest">误差变差试验属性信息</param>
        /// <returns></returns>
        int sendErrorVariationTest(DetectHead head, ErrorVariationTest errorVariationTest);


        /// <summary>
        /// 误差一致性试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="errorConsistencyTest">误差一致性试验属性信息</param>
        /// <returns></returns>
        int sendErrorConsistencyTest(DetectHead head, ErrorConsistencyTest errorConsistencyTest);


        /// <summary>
        /// 负载电流升降变差试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentLoadUpdownVarErr">负载电流升降变差试验属性信息</param>
        /// <returns></returns>
        int sendCurrentLoadUpdownVarErr(DetectHead head, CurrentLoadUpdownVarErr currentLoadUpdownVarErr);


        /// <summary>
        /// 电流过载试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">电流过载试验属性信息</param>
        /// <returns></returns>
        int sendCurrentOverLoad(DetectHead head, CurrentOverLoad currentOverLoad);


        /// <summary>
        /// 计数器示值组合误差
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="currentOverLoad">计数器示值组合误差属性信息</param>
        /// <returns></returns>
        int sendCounterValueCombineError(DetectHead head, CounterValueCombineError counterValueCombineError);
    }
}
