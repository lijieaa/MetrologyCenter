using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 费率时段电能示值误差
    /// </summary>
    public class RatePeriodValueError
    {
        float start_total_value;//开始总
        float start_peak_value;// 开始峰
        float start_shoulder_value;// 开始平
        float start_valley_value;// 开始谷
        float start_sharp_value;// 开始尖
        float end_total_value;//结束总
        float end_peak_value;// 结束峰
        float end_shoulder_value;// 结束平
        float end_valley_value;// 结束谷
        float end_sharp_value;// 结束尖
        float total_error;//总差值
        float total_rate_error_sum;//所有费率差值和
        float sum_rate_error;//总和费率差值
        int result;//结论

    }
}
