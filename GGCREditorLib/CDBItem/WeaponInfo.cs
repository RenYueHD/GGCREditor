using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 武器信息(36Byte)
    /// </summary>
    public abstract class WeaponInfo : GGCRUnitInfo<GundamFile>, IComparable<WeaponInfo>
    {

        protected const int GROUP_IDX = 0;
        protected const int ID_IDX = GROUP_IDX + 8;       //武器编号 2byte
        protected const int RANGE_IDX = GROUP_IDX + 10;       //射程 2byte
        protected const int POWER_IDX = GROUP_IDX + 12;        //威力/100  2byte
        protected const int EN_IDX = GROUP_IDX + 14;   //EN消费 2byte
        protected const int MP_IDX = GROUP_IDX + 16;   //MP消费 2byte
        protected const int ACT_EARTH_IDX = GROUP_IDX + 18;    //武器对应适性 2byte
        protected const int MOVE_ACT_IDX = GROUP_IDX + 20;     //移动后攻击 1byte
        protected const int ICO_IDX = GROUP_IDX + 22;          //图标
        protected const int PROPER_IDX = GROUP_IDX + 21;         //武器属性
        protected const int SPEC_IDX = GROUP_IDX + 23;        //武器特效 1byte
        protected const int MP_LIMIT_IDX = GROUP_IDX + 24;    //MP需求 2byte
        protected const int USE_EARTH_IDX = GROUP_IDX + 26;   //使用适性 1?2byte
        protected const int RANGE1_IDX = GROUP_IDX + 28;       //射程 1byte 修改无效
        protected const int RANGE2_IDX = GROUP_IDX + 29;        //射程 1byte 修改无效


        public WeaponInfo(GundamFile gundamFile, int index, int no)
            : base(gundamFile, index, no)
        {

        }

        public string GumdamUUID
        {
            get
            {
                byte[] bt = new byte[8];
                Array.Copy(this.Data, bt, 8);
                return ByteHelper.ByteArrayToHexString(bt);
            }
        }

        public bool IsMap
        {
            get
            {
                return this is WeaponMapInfo;
            }
        }

        public override string UnitName
        {
            get
            {
                if (this.ID < 0 || PkdFile.AllText[this.ID] == null || PkdFile.AllText[this.ID].Trim().Length == 0)
                {
                    return "未知";
                }
                else
                {
                    return PkdFile.AllText[this.ID];
                }
            }
        }


        public override void SaveUnitName(string name)
        {
            int idx = this.ID;
            GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.MachineTxtFile);
            List<string> list = txtFile.ListAllText();
            if (list.Count > idx)
            {
                list[idx] = name;
                txtFile.Save(list);
                PkdFile.AllText[idx] = name;
            }
        }

        public string GroupName
        {
            get
            {
                if (PkdFile.SeriesCode.ContainsKey(this.Group))
                {
                    return PkdFile.SeriesCode[this.Group];
                }
                else
                {
                    return "未知系列" + this.Group;
                }
            }
        }

        public short Group
        {
            get
            {
                return BitConverter.ToInt16(this.Data, GROUP_IDX);
            }
        }


        public short ID
        {
            get
            {
                return BitConverter.ToInt16(this.Data, ID_IDX);
            }
        }

        public short Range
        {
            get
            {
                return BitConverter.ToInt16(this.Data, RANGE_IDX);
            }
            set
            {
                save(RANGE_IDX, value);
            }
        }

        public int POWER
        {
            get
            {
                return BitConverter.ToInt16(this.Data, POWER_IDX) * 100;
            }
            set
            {
                save(POWER_IDX, (short)(value / 100));
            }
        }

        public short EN
        {
            get
            {
                return BitConverter.ToInt16(this.Data, EN_IDX);
            }
            set
            {
                save(EN_IDX, value);
            }
        }

        public short MP
        {
            get
            {
                return BitConverter.ToInt16(this.Data, MP_IDX);
            }
            set
            {
                save(MP_IDX, value);
            }
        }

        public string ActEarth
        {
            get
            {
                return Convert.ToString(BitConverter.ToInt16(this.Data, ACT_EARTH_IDX), 2).PadLeft(10, '0');
            }
            set
            {
                save(ACT_EARTH_IDX, Convert.ToInt16(value, 2));
            }
        }

        public byte MoveACT
        {
            get
            {
                return this.Data[MOVE_ACT_IDX];
            }
            set
            {
                save(MOVE_ACT_IDX, value);
            }
        }

        public byte ICO
        {
            get
            {
                return this.Data[ICO_IDX];
            }
            set
            {
                save(ICO_IDX, value);
            }
        }

        public byte PROPER
        {
            get
            {
                return this.Data[PROPER_IDX];
            }
            set
            {
                save(PROPER_IDX, value);
            }
        }

        public byte Spec
        {
            get
            {
                return this.Data[SPEC_IDX];
            }
            set
            {
                save(SPEC_IDX, value);
            }
        }

        public short MPLimit
        {
            get
            {
                return BitConverter.ToInt16(this.Data, MP_LIMIT_IDX);
            }
            set
            {
                save(MP_LIMIT_IDX, value);
            }
        }

        public string UseEarth
        {
            get
            {
                return Convert.ToString(BitConverter.ToInt16(this.Data, USE_EARTH_IDX), 2).PadLeft(5, '0');
            }
            set
            {
                save(USE_EARTH_IDX, Convert.ToInt16(value, 2));
            }
        }

        public byte Range1
        {
            get
            {
                return this.Data[RANGE1_IDX];
            }
            set
            {
                save(RANGE1_IDX, value);
            }
        }

        public byte Range2
        {
            get
            {
                return this.Data[RANGE2_IDX];
            }
            set
            {
                save(RANGE2_IDX, value);
            }
        }


        public override int UnitLength
        {
            get
            {
                return GGCRStaticConfig.WeaponLength;
            }
        }

        public override int UUID_START
        {
            get
            {
                return 0;
            }
        }

        public override int UUID_LENGTH
        {
            get
            {
                return GGCRStaticConfig.WeaponUIDLength;
            }
        }

        public int CompareTo(WeaponInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
