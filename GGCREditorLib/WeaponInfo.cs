using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 武器信息(36Byte)
    /// </summary>
    public class WeaponInfo : GGCRUnitInfo<GundamFile>, IComparable<WeaponInfo>
    {

        private const int GROUP_IDX = 0;
        private const int ID_IDX = GROUP_IDX + 8;       //武器编号 2byte
        private const int RANGE_IDX = ID_IDX + 2;       //射程 2byte
        private const int POWER_IDX = ID_IDX + 4;        //威力/100  2byte
        private const int EN_IDX = POWER_IDX + 2;   //EN消费 2byte
        private const int MP_IDX = POWER_IDX + 4;   //MP消费 2byte
        private const int ACT_EARTH_IDX = POWER_IDX + 6;    //武器对应适性 2byte
        private const int MOVE_ACT_IDX = POWER_IDX + 8;     //移动后攻击 1byte
        private const int ICO_IDX = POWER_IDX + 9;          //图标
        private const int PROPER_IDX = POWER_IDX + 10;         //武器属性
        private const int SPEC_IDX = POWER_IDX + 11;        //武器特效 1byte
        private const int MP_LIMIT_IDX = POWER_IDX + 12;    //MP需求 2byte
        private const int USE_EARTH_IDX = POWER_IDX + 14;   //使用适性 1?2byte
        private const int RANGE1_IDX = POWER_IDX + 16;       //射程 1byte 修改无效???
        private const int RANGE2_IDX = POWER_IDX + 17;
        private const int HIT_RATE_IDX = POWER_IDX + 18;    //命中 1byte
        private const int CT_RATE_IDX = POWER_IDX + 19;     //暴击 1byte
        private const int HIT_COUNT_IDX = POWER_IDX + 20;   //Hit次数 1byte

        public WeaponInfo(GundamFile gundamFile, int index, int no)
            : base(gundamFile, index, no)
        {

        }

        public string WeaponName
        {
            get
            {
                if (this.ID < 0 || PkdFile.weaponNames[this.ID] == null || PkdFile.weaponNames[this.ID].Trim().Length == 0)
                {
                    return "未知";
                }
                else
                {
                    return PkdFile.weaponNames[this.ID];
                }
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
                save(POWER_IDX, (short)value / 100);
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

        public byte HitRate
        {
            get
            {
                return this.Data[HIT_RATE_IDX];
            }
            set
            {
                save(HIT_RATE_IDX, value);
            }
        }

        public byte CT
        {
            get
            {
                return this.Data[CT_RATE_IDX];
            }
            set
            {
                save(CT_RATE_IDX, value);
            }
        }

        public byte HitCount
        {
            get
            {
                return this.Data[HIT_COUNT_IDX];
            }
            set
            {
                save(HIT_COUNT_IDX, value);
            }
        }


        public override int UnitLength
        {
            get
            {
                return 36;
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
                return 10;
            }
        }

        public int CompareTo(WeaponInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
