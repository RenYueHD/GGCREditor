using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 武器信息(36Byte)
    /// </summary>
    public class WeaponInfo : IComparable<WeaponInfo>
    {

        private GundamFile gundamFile;

        private const int ID_IDX = 0;       //武器编号 2byte
        private const int UNKONW_IDX = 2;       //未知 2byte
        private const int POWER_IDX = 4;        //威力/100  2byte
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


        /// <summary>
        /// 索引,以POWER值为0
        /// </summary>
        public int Index { get; set; }

        public string WeaponName { get; set; }

        public WeaponInfo(GundamFile gundamFile, int index)
        {
            this.gundamFile = gundamFile;
            this.Index = index;
        }

        public short ID
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + ID_IDX);
            }
        }

        public short Unknow
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + UNKONW_IDX);
            }
        }

        public int POWER
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + POWER_IDX) * 100;
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
                return BitConverter.ToInt16(gundamFile.Data, Index + EN_IDX);
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
                return BitConverter.ToInt16(gundamFile.Data, Index + MP_IDX);
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
                string shiyin = Convert.ToString(BitConverter.ToInt16(gundamFile.Data, Index + ACT_EARTH_IDX), 2);

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
                return gundamFile.Data[Index + MOVE_ACT_IDX];
            }
            set
            {
                gundamFile.Data[Index + MOVE_ACT_IDX] = value;
            }
        }

        public byte ICO
        {
            get
            {
                return gundamFile.Data[Index + ICO_IDX];
            }
            set
            {
                gundamFile.Data[Index + ICO_IDX] = value;
            }
        }

        public byte PROPER
        {
            get
            {
                return gundamFile.Data[Index + PROPER_IDX];
            }
            set
            {
                gundamFile.Data[Index + PROPER_IDX] = value;
            }
        }

        public byte Spec
        {
            get
            {
                return gundamFile.Data[Index + SPEC_IDX];
            }
            set
            {
                gundamFile.Data[Index + SPEC_IDX] = value;
            }
        }

        public short MPLimit
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + MP_LIMIT_IDX);
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
                string shiyin = Convert.ToString(BitConverter.ToInt16(gundamFile.Data, Index + USE_EARTH_IDX), 2);

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
                return gundamFile.Data[Index + RANGE1_IDX];
            }
            set
            {
                gundamFile.Data[Index + RANGE1_IDX] = value;
            }
        }

        public byte Range2
        {
            get
            {
                return gundamFile.Data[Index + RANGE2_IDX];
            }
            set
            {
                gundamFile.Data[Index + RANGE2_IDX] = value;
            }
        }

        public byte HitRate
        {
            get
            {
                return gundamFile.Data[Index + HIT_RATE_IDX];
            }
            set
            {
                gundamFile.Data[Index + HIT_RATE_IDX] = value;
            }
        }

        public byte CT
        {
            get
            {
                return gundamFile.Data[Index + CT_RATE_IDX];
            }
            set
            {
                gundamFile.Data[Index + CT_RATE_IDX] = value;
            }
        }

        public byte HitCount
        {
            get
            {
                return gundamFile.Data[Index + HIT_COUNT_IDX];
            }
            set
            {
                gundamFile.Data[Index + HIT_COUNT_IDX] = value;
            }
        }


        public string Address
        {
            get
            {
                return ByteHelper.ByteArrayToHexString(ByteHelper.Int2Bytes(this.Index));
            }
        }

        private void save(int index, short value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                gundamFile.Data[index + i] = arr[i];
            }
        }

        private void save(int index, int value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                gundamFile.Data[index + i] = arr[i];
            }
        }

        public int CompareTo(WeaponInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
