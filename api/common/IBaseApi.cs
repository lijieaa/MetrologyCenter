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


        /// <summary>
        /// 日计时误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="dayTimingError">日计时误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendDayTimingError(DetectHead head, DayTimingError dayTimingError);


        /// <summary>
        /// 功率消耗（单相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="oPowerConsume">功率消耗（单相表）属性信息</param>
        /// <returns></returns>
        int sendOPowerConsume(DetectHead head, OPowerConsume oPowerConsume);


        /// <summary>
        /// 功率消耗（三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="tPowerConsume">功率消耗（三相表）属性信息</param>
        /// <returns></returns>
        int sendTPowerConsume(DetectHead head, TPowerConsume tPowerConsume);


        /// <summary>
        /// 交流电压试验（单相表、三相表）（耐压）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="aCVoltTest">交流电压试验（单相表、三相表）（耐压）属性信息</param>
        /// <returns></returns>
        int sendACVoltTest(DetectHead head, ACVoltTest aCVoltTest);

        /// <summary>
        /// 时段投切误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="periodFlingCutError">交流电压试验（单相表、三相表）（耐压）属性信息</param>
        /// <returns></returns>
        int sendPeriodFlingCutError(DetectHead head, PeriodFlingCutError periodFlingCutError);


        /// <summary>
        /// 走字试验（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="runningTest">走字试验（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendRunningTest(DetectHead head, RunningTest runningTest);

        /// <summary>
        /// 需量周期误差（单相表、三相表）
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">需量周期误差（单相表、三相表）属性信息</param>
        /// <returns></returns>
        int sendNeedQperiodError(DetectHead head, NeedQperiodError needQperiodError);


        /// <summary>
        /// 拉合闸试验
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="needQperiodError">拉合闸试验属性信息</param>
        /// <returns></returns>
        int sendSwitchTest(DetectHead head, SwitchTest switchTest);


        /// <summary>
        /// 对时功能
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="syncTimeTest">对时功能属性信息</param>
        /// <returns></returns>
        int sendSyncTimeTest(DetectHead head, SyncTimeTest syncTimeTest);




        /// <summary>
        /// 读通信地址
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="readAddr">读通信地址属性信息</param>
        /// <returns></returns>
        int sendReadAddr(DetectHead head, ReadAddr readAddr);


        /// <summary>
        /// 身份认证
        /// </summary>
        /// <param name="head">公共属性信息</param>
        /// <param name="iDAuthentication">身份认证属性信息</param>
        /// <returns></returns>
        int sendIDAuthentication(DetectHead head, IDAuthentication iDAuthentication);
    }
}
