using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.entity.process
{
    public class DetectHead
    {
        string orgId;//管理单位
        string systemId;//设备厂商编号
        string testWay;//检定方式
        string equipCateg;//设备类别
        string detectLineId;//检定线体编号
        string detectStationId;//检定线台编号
        string detectUnitId;//检定单元编号
        string detectUnitNo;//单元序号
        string typeId;//数据对象ID
        string meterId;//表位编号
        string barCode;//表条码

        public string OrgId
        {
            get
            {
                return orgId;
            }

            set
            {
                orgId = value;
            }
        }

        public string SystemId
        {
            get
            {
                return systemId;
            }

            set
            {
                systemId = value;
            }
        }

        public string TestWay
        {
            get
            {
                return testWay;
            }

            set
            {
                testWay = value;
            }
        }

        public string EquipCateg
        {
            get
            {
                return equipCateg;
            }

            set
            {
                equipCateg = value;
            }
        }

        public string DetectLineId
        {
            get
            {
                return detectLineId;
            }

            set
            {
                detectLineId = value;
            }
        }

        public string DetectStationId
        {
            get
            {
                return detectStationId;
            }

            set
            {
                detectStationId = value;
            }
        }

        public string DetectUnitId
        {
            get
            {
                return detectUnitId;
            }

            set
            {
                detectUnitId = value;
            }
        }

        public string DetectUnitNo
        {
            get
            {
                return detectUnitNo;
            }

            set
            {
                detectUnitNo = value;
            }
        }

        public string TypeId
        {
            get
            {
                return string.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}"
                , this.OrgId
                , this.SystemId
                , this.TestWay
                , this.EquipCateg
                , this.DetectLineId
                , this.DetectStationId
                , this.DetectUnitId
                , this.DetectUnitNo
                , this.meterId
                , this.typeId
                );
            }

            set
            {
                typeId = value;
            }
        }

        public string MeterId
        {
            get
            {
                return string.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}"
                , this.OrgId 
                , this.SystemId 
                , this.TestWay
                , this.EquipCateg 
                , this.DetectLineId  
                , this.DetectStationId 
                , this.DetectUnitId 
                , this.DetectUnitNo 
                , this.meterId
                ); ;
            }

            set
            {
                meterId = value;
            }
        }

        public string BarCode
        {
            get
            {
                return barCode;
            }

            set
            {
                barCode = value;
            }
        }

        public DetectHead(string orgId, string systemId, string testWay, string equipCateg, string detectLineId, string detectStationId, string detectUnitId, string detectUnitNo, string typeId, string meterId, string barCode)
        {
            this.orgId = orgId;
            this.systemId = systemId;
            this.testWay = testWay;
            this.equipCateg = equipCateg;
            this.detectLineId = detectLineId;
            this.detectStationId = detectStationId;
            this.detectUnitId = detectUnitId;
            this.detectUnitNo = detectUnitNo;
            this.typeId = typeId;
            this.meterId = meterId;
            this.barCode = barCode;
        }


        public override string ToString()
        {
            return string.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}_{10}"
                , this.OrgId
                , this.SystemId
                , this.TestWay
                , this.EquipCateg
                , this.DetectLineId
                , this.DetectStationId
                , this.DetectUnitId
                , this.DetectUnitNo
                , this.meterId
                , this.typeId
                , this.BarCode
                );
        }
    }
}
