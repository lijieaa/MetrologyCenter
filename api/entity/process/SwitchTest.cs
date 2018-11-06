using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 拉合闸试验
    /// </summary>
    public class SwitchTest
    {
        int switchOutBeforeStatus;//拉闸前状态
        int switchOutAfterStatus;//拉闸后状态
        int switchOnBeforeStatus;//合闸前状态
        int switchOnAfterStatus;//合闸后状态
        int result;//结论

        public int SwitchOutBeforeStatus
        {
            get
            {
                return switchOutBeforeStatus;
            }

            set
            {
                switchOutBeforeStatus = value;
            }
        }

        public int SwitchOutAfterStatus
        {
            get
            {
                return switchOutAfterStatus;
            }

            set
            {
                switchOutAfterStatus = value;
            }
        }

        public int SwitchOnBeforeStatus
        {
            get
            {
                return switchOnBeforeStatus;
            }

            set
            {
                switchOnBeforeStatus = value;
            }
        }

        public int SwitchOnAfterStatus
        {
            get
            {
                return switchOnAfterStatus;
            }

            set
            {
                switchOnAfterStatus = value;
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

        public SwitchTest(int switchOutBeforeStatus, int switchOutAfterStatus, int switchOnBeforeStatus, int switchOnAfterStatus, int result)
        {
            this.switchOutBeforeStatus = switchOutBeforeStatus;
            this.switchOutAfterStatus = switchOutAfterStatus;
            this.switchOnBeforeStatus = switchOnBeforeStatus;
            this.switchOnAfterStatus = switchOnAfterStatus;
            this.result = result;
        }
    }
}
