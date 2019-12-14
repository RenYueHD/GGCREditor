using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 普通武器信息
    /// </summary>
    public class WeaponNormalInfo : WeaponInfo
    {
        public WeaponNormalInfo(GundamFile gundamFile, int index, int no)
            : base(gundamFile, index, no)
        {
        }

        protected const int HIT_RATE_IDX = GROUP_IDX + 30;    //命中 1byte
        protected const int CT_RATE_IDX = GROUP_IDX + 31;     //暴击 1byte
        protected const int HIT_COUNT_IDX = GROUP_IDX + 32;   //Hit次数 1byte


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
    }
}
