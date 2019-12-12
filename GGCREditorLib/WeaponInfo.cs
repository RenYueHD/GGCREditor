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
        private const int RANGE = ID_IDX + 2;       //射程 2byte
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
                if (PkdFile.groups.ContainsKey(this.Group.ToString()))
                {
                    return PkdFile.groups[this.Group.ToString()];
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
                return BitConverter.ToInt16(PkdFile.Data, Index + GROUP_IDX);
            }
        }


        public short ID
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + ID_IDX);
            }
        }

        public short Range
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + RANGE);
            }
            set
            {
                save(Index + RANGE, value);
            }
        }

        public int POWER
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + POWER_IDX) * 100;
            }
            set
            {
                save(Index + POWER_IDX, (short)value / 100);
            }
        }

        public short EN
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + EN_IDX);
            }
            set
            {
                save(Index + EN_IDX, value);
            }
        }

        public short MP
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + MP_IDX);
            }
            set
            {
                save(Index + MP_IDX, value);
            }
        }

        public string ActEarth
        {
            get
            {
                string shiyin = Convert.ToString(BitConverter.ToInt16(PkdFile.Data, Index + ACT_EARTH_IDX), 2);

                int s = 10 - shiyin.Length;
                for (int i = 0; i < s; i++)
                {
                    shiyin = "0" + shiyin;
                }
                return shiyin;
            }
            set
            {
                short v = Convert.ToInt16(value, 2);
                save(Index + ACT_EARTH_IDX, v);
            }
        }

        public byte MoveACT
        {
            get
            {
                return PkdFile.Data[Index + MOVE_ACT_IDX];
            }
            set
            {
                PkdFile.Data[Index + MOVE_ACT_IDX] = value;
            }
        }

        public byte ICO
        {
            get
            {
                return PkdFile.Data[Index + ICO_IDX];
            }
            set
            {
                PkdFile.Data[Index + ICO_IDX] = value;
            }
        }

        public byte PROPER
        {
            get
            {
                return PkdFile.Data[Index + PROPER_IDX];
            }
            set
            {
                PkdFile.Data[Index + PROPER_IDX] = value;
            }
        }

        public byte Spec
        {
            get
            {
                return PkdFile.Data[Index + SPEC_IDX];
            }
            set
            {
                PkdFile.Data[Index + SPEC_IDX] = value;
            }
        }

        public short MPLimit
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + MP_LIMIT_IDX);
            }
            set
            {
                save(Index + MP_LIMIT_IDX, value);
            }
        }

        public string UseEarth
        {
            get
            {
                string shiyin = Convert.ToString(BitConverter.ToInt16(PkdFile.Data, Index + USE_EARTH_IDX), 2);

                int s = 5 - shiyin.Length;
                for (int i = 0; i < s; i++)
                {
                    shiyin = "0" + shiyin;
                }
                return shiyin;
            }
            set
            {
                short v = Convert.ToInt16(value, 2);
                save(Index + USE_EARTH_IDX, v);
            }
        }

        public byte Range1
        {
            get
            {
                return PkdFile.Data[Index + RANGE1_IDX];
            }
            set
            {
                PkdFile.Data[Index + RANGE1_IDX] = value;
            }
        }

        public byte Range2
        {
            get
            {
                return PkdFile.Data[Index + RANGE2_IDX];
            }
            set
            {
                PkdFile.Data[Index + RANGE2_IDX] = value;
            }
        }

        public byte HitRate
        {
            get
            {
                return PkdFile.Data[Index + HIT_RATE_IDX];
            }
            set
            {
                PkdFile.Data[Index + HIT_RATE_IDX] = value;
            }
        }

        public byte CT
        {
            get
            {
                return PkdFile.Data[Index + CT_RATE_IDX];
            }
            set
            {
                PkdFile.Data[Index + CT_RATE_IDX] = value;
            }
        }

        public byte HitCount
        {
            get
            {
                return PkdFile.Data[Index + HIT_COUNT_IDX];
            }
            set
            {
                PkdFile.Data[Index + HIT_COUNT_IDX] = value;
            }
        }


        public int CompareTo(WeaponInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
