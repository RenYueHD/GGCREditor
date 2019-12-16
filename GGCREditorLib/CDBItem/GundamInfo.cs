using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 机体信息(108Byte)
    /// </summary>
    public class GundamInfo : GGCRUnitInfo<GundamFile>, IComparable<GundamInfo>
    {
        private const int GROUP_IDX = 0;
        private const int HP_IDX = GROUP_IDX + 24;
        private const int ID_IDX = HP_IDX - 2;
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
        //第一武器地址 2byte
        private const int WEAPON_IDX = HP_IDX + 66;
        //第一MAP地址 2byte
        private const int WEAPON_MAP_IDX = HP_IDX + 68;
        //移动 2byte
        private const int MOVE_IDX = HP_IDX + 70;
        //武器数量(MAP除外)
        private const int WEAPON_COUNT_IDX = HP_IDX + 73;
        private const int WEAPON_MAP_COUNT_IDX = HP_IDX + 74;
        //体积 1byte
        private const int SIZE_IDX = HP_IDX + 71;


        public GundamInfo(GundamFile gundamFile, int index, int no)
            : base(gundamFile, index, no)
        {

        }

        public virtual string PicName
        {
            get
            {

                return Encoding.ASCII.GetString(this.Data, 2, 1) + BitConverter.ToInt16(this.Data, 0).ToString().PadLeft(4, '0') + Encoding.ASCII.GetString(this.Data, 4, 1)
                            + BitConverter.ToInt16(this.Data, 6).ToString().PadLeft(3, '0')
                            + this.Data[5].ToString().PadLeft(2, '0');
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
                    return "未知" + this.Group;
                }
            }
        }

        public override string UnitName
        {
            get
            {
                if (PkdFile.gundamName[this.No] == null || PkdFile.gundamName[this.No].Trim().Length == 0)
                {
                    return "未知";
                }
                else
                {
                    return PkdFile.gundamName[this.No];
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

        public int HP
        {
            get
            {
                return BitConverter.ToInt32(this.Data, HP_IDX);
            }
            set
            {
                save(HP_IDX, value);
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

        public short ACT
        {
            get
            {
                return BitConverter.ToInt16(this.Data, ACT_IDX);
            }
            set
            {
                save(ACT_IDX, value);
            }
        }

        public short DEF
        {
            get
            {
                return BitConverter.ToInt16(this.Data, DEF_IDX);
            }
            set
            {
                save(DEF_IDX, value);
            }
        }

        public short SPD
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SPD_IDX);
            }
            set
            {
                save(SPD_IDX, value);
            }
        }

        public byte Move
        {
            get
            {
                return this.Data[MOVE_IDX];
            }
            set
            {
                save(MOVE_IDX, value);
            }
        }

        public byte Size
        {
            get
            {
                return this.Data[SIZE_IDX];
            }
            set
            {
                save(SIZE_IDX, value);
            }
        }

        public string Earch
        {
            get
            {
                return Convert.ToString(BitConverter.ToInt16(this.Data, EARTH_IDX), 8).PadLeft(5, '0');
            }
            set
            {
                save(EARTH_IDX, Convert.ToInt16(value, 8));
            }
        }

        public short EarchSize
        {
            get
            {
                return BitConverter.ToInt16(this.Data, EARTH_SIZE_IDX);
            }
            set
            {
                save(EARTH_SIZE_IDX, value);
            }
        }

        public short Skill1
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SKILL_IDX);
            }
            set
            {
                save(SKILL_IDX, value);
            }
        }

        public short Skill2
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SKILL_IDX + 2);
            }
            set
            {
                save(SKILL_IDX + 2, value);
            }
        }

        public short Skill3
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SKILL_IDX + 4);
            }
            set
            {
                save(SKILL_IDX + 4, value);
            }
        }

        public short Skill4
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SKILL_IDX + 6);
            }
            set
            {
                save(SKILL_IDX + 6, value);
            }
        }

        public short Skill5
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SKILL_IDX + 8);
            }
            set
            {
                save(SKILL_IDX + 8, value);
            }
        }

        public short WeaponId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, WEAPON_IDX);
            }
            set
            {
                save(WEAPON_IDX, value);
            }
        }

        public byte WeaponCount
        {
            get
            {
                return this.Data[WEAPON_COUNT_IDX];
            }
            set
            {
                save(WEAPON_COUNT_IDX, value);
            }
        }

        public short WeaponMapID
        {
            get
            {
                return BitConverter.ToInt16(this.Data, WEAPON_MAP_IDX);
            }
            set
            {
                save(WEAPON_MAP_IDX, value);
            }
        }

        public byte WeaponMapCount
        {
            get
            {
                return this.Data[WEAPON_MAP_COUNT_IDX];
            }
            set
            {
                save(WEAPON_MAP_COUNT_IDX, value);
            }
        }



        public override int UnitLength
        {
            get
            {
                return GGCRStaticConfig.GundamLength;
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
                return GGCRStaticConfig.GundamUIDLength;
            }
        }


        public int CompareTo(GundamInfo other)
        {
            return this.Index - other.Index;
        }

    }
}
