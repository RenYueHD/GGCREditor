using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    public class GundamInfo : IComparable<GundamInfo>
    {

        private GundamFile gundamFile;

        private const int HP_IDX = 0;
        private const int EN_IDX = HP_IDX + 38;
        private const int ACT_IDX = HP_IDX + 40;
        private const int DEF_IDX = HP_IDX + 42;
        private const int SPD_IDX = HP_IDX + 44;
        //地形适性 2byte
        private const int EARTH_IDX = HP_IDX + 52;
        //地图占用面积
        private const int EARTH_SIZE_IDX = HP_IDX + 54;
        //技能 10byte
        private const int SKILL_IDX = HP_IDX + 56;
        //第一武器地址 4byte
        private const int WEAPON_IDX = HP_IDX + 66;
        //移动 2byte
        private const int MOVE_IDX = HP_IDX + 70;
        //武器数量(MAP除外)
        private const int WEAPON_COUNT_IDX = HP_IDX + 73;
        //体积 1byte
        private const int SIZE_IDX = HP_IDX + 71;



        /// <summary>
        /// 索引,以HP值为0
        /// </summary>
        public int Index { get; set; }

        public string GundamName { get; set; }

        public GundamInfo(GundamFile gundamFile, int index)
        {
            this.gundamFile = gundamFile;
            this.Index = index;
        }

        public short HP
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + HP_IDX);
            }
            set
            {
                save(Index + HP_IDX, value);
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

        public short ACT
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + ACT_IDX);
            }
            set
            {
                save(Index + ACT_IDX, value);
            }
        }

        public short DEF
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + DEF_IDX);
            }
            set
            {
                save(Index + DEF_IDX, value);
            }
        }

        public short SPD
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SPD_IDX);
            }
            set
            {
                save(Index + SPD_IDX, value);
            }
        }

        public byte Move
        {
            get
            {
                return gundamFile.Data[Index + MOVE_IDX];
            }
            set
            {
                gundamFile.Data[Index + MOVE_IDX] = value;
            }
        }

        public byte Size
        {
            get
            {
                return gundamFile.Data[Index + SIZE_IDX];
            }
            set
            {
                gundamFile.Data[Index + SIZE_IDX] = value;
            }
        }

        public string Earch
        {
            get
            {
                string shiyin = Convert.ToString(BitConverter.ToInt16(gundamFile.Data, Index + EARTH_IDX), 8);

                int s = 5 - shiyin.Length;
                for (int i = 0; i < s; i++)
                {
                    shiyin = "0" + shiyin;
                }
                return shiyin;
            }
            set
            {
                short v = Convert.ToInt16(value, 8);
                save(Index + EARTH_IDX, v);
            }
        }

        public short EarchSize
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + EARTH_SIZE_IDX);
            }
            set
            {
                save(Index + EARTH_SIZE_IDX, value);
            }
        }

        public short Skill1
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SKILL_IDX);
            }
            set
            {
                save(Index + SKILL_IDX, value);
            }
        }

        public short Skill2
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SKILL_IDX + 2);
            }
            set
            {
                save(Index + SKILL_IDX + 2, value);
            }
        }

        public short Skill3
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SKILL_IDX + 4);
            }
            set
            {
                save(Index + SKILL_IDX + 4, value);
            }
        }

        public short Skill4
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SKILL_IDX + 6);
            }
            set
            {
                save(Index + SKILL_IDX + 6, value);
            }
        }

        public short Skill5
        {
            get
            {
                return BitConverter.ToInt16(gundamFile.Data, Index + SKILL_IDX + 8);
            }
            set
            {
                save(Index + SKILL_IDX + 8, value);
            }
        }

        public int WeaponIndex
        {
            get
            {
                return BitConverter.ToInt32(gundamFile.Data, Index + WEAPON_IDX);
            }
            set
            {
                save(Index + WEAPON_IDX, value);
            }
        }

        public byte WeaponCount
        {
            get
            {
                return gundamFile.Data[Index + WEAPON_COUNT_IDX];
            }
            set
            {
                gundamFile.Data[Index + WEAPON_COUNT_IDX] = value;
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

        public int CompareTo(GundamInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
