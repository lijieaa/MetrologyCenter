using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    /// <summary>
    /// 对时功能
    /// </summary>
    public class SyncTimeTest
    {
        string syncBefore;//对时前电能表时间
        string syncAfter;//对时后电能表时间
        int result;//结论

        public string SyncBefore
        {
            get
            {
                return syncBefore;
            }

            set
            {
                syncBefore = value;
            }
        }

        public string SyncAfter
        {
            get
            {
                return syncAfter;
            }

            set
            {
                syncAfter = value;
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

        public SyncTimeTest(string syncBefore, string syncAfter, int result)
        {
            this.syncBefore = syncBefore;
            this.syncAfter = syncAfter;
            this.result = result;
        }
    }
}
