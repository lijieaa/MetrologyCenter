using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.entity.common;

namespace api.entity.process
{
    /// <summary>
    /// 剩余电能量递减准确度
    /// </summary>
    class SurplusEQDescendEntity : BaseEntity
    {
        string powDirection;//功率方向
        string loadCurrent;//电流负载
        string powFactor;//功率因数
        float totalEq;//总电量
        float surplusEq;//剩余电量
        int result;//结论


        public SurplusEQDescendEntity(string orgId, string systemId, string testWay, string equipCateg, string detectLineId, string detectStationId, string detectUnitId, string detectUnitNo, string typeId, string meterId, string barCode, string powDirection, string loadCurrent, string powFactor, float totalEq, float surplusEq, int result) 
            : base(orgId, systemId, testWay, equipCateg, detectLineId, detectStationId, detectUnitId, detectUnitNo, typeId, meterId, barCode)
        {
            this.powDirection = powDirection;
            this.loadCurrent = loadCurrent;
            this.powFactor = powFactor;
            this.totalEq = totalEq;
            this.surplusEq = surplusEq;
            this.result = result;
        }
        public string PowDirection
        {
            get
            {
                return powDirection;
            }

            set
            {
                powDirection = value;
            }
        }

        public string LoadCurrent
        {
            get
            {
                return loadCurrent;
            }

            set
            {
                loadCurrent = value;
            }
        }

        public string PowFactor
        {
            get
            {
                return powFactor;
            }

            set
            {
                powFactor = value;
            }
        }

        public float TotalEq
        {
            get
            {
                return totalEq;
            }

            set
            {
                totalEq = value;
            }
        }

        public float SurplusEq
        {
            get
            {
                return surplusEq;
            }

            set
            {
                surplusEq = value;
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
