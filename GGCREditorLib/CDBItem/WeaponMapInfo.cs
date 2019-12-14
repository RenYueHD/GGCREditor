using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// MAP武器信息
    /// </summary>
    public class WeaponMapInfo : WeaponInfo
    {
        public WeaponMapInfo(GundamFile gundamFile, int index, int no)
            : base(gundamFile, index, no)
        {
        }

        protected int MAP_TURN_IDX = GROUP_IDX + 30;    //MAP转向需求 2byte
        protected int WEAPON_TYPE_IDX = GROUP_IDX + 32;    //武器类型 1byte
        protected int ATT_MAX_COUNT_IDX = GROUP_IDX + 33;

        public short MapTurn
        {
            get
            {
                return BitConverter.ToInt16(this.Data, MAP_TURN_IDX);
            }
            set
            {
                save(MAP_TURN_IDX, value);
            }
        }

        public byte WeaponType
        {
            get
            {
                return this.Data[WEAPON_TYPE_IDX];
            }
            set
            {
                save(WEAPON_TYPE_IDX, value);
            }
        }

        public byte AttMaxCount
        {
            get
            {
                return this.Data[ATT_MAX_COUNT_IDX];
            }
            set
            {
                save(ATT_MAX_COUNT_IDX, value);
            }
        }
    }
}
