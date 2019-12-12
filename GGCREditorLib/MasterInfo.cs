using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 角色信息(112Byte)
    /// </summary>
    public class MasterInfo : GGCRUnitInfo<MasterFile>, IComparable<MasterInfo>
    {
        private const int GROUP_IDX = 0;
        private const int ID_IDX = SHEJI_IDX - 4;
        private const int UNKNOW_IDX = SHEJI_IDX - 2;
        private const int SHEJI_IDX = GROUP_IDX + 32;
        private const int GEDOU_IDX = SHEJI_IDX + 2;
        private const int SHOUBEI_IDX = SHEJI_IDX + 4;
        private const int FANYIN_IDX = SHEJI_IDX + 6;
        private const int JUEXIN_IDX = SHEJI_IDX + 8;
        private const int ZHIHUI_IDX = SHEJI_IDX + 10;
        private const int FUZUO_IDX = SHEJI_IDX + 12;
        private const int TONGXUN_IDX = SHEJI_IDX + 14;
        private const int CAODUO_IDX = SHEJI_IDX + 16;
        private const int WEIXIU_IDX = SHEJI_IDX + 18;
        private const int MEILI_IDX = SHEJI_IDX + 20;
        private const int JINYAN_IDX = SHEJI_IDX + 22;
        private const int CHENGZHANG_IDX = SHEJI_IDX + 26;
        private const int GUYOU1_IDX = SHEJI_IDX + 28;
        private const int GUYOU2_IDX = SHEJI_IDX + 30;
        private const int GUYOU3_IDX = SHEJI_IDX + 32;

        private const int LAST4_IDX = GROUP_IDX + 108;


        public MasterInfo(MasterFile File, int index, int no)
            : base(File, index, no)
        {

        }


        public string MasterName
        {
            get
            {
                if (this.ID < 0 || PkdFile.masterNames[this.ID] == null || PkdFile.masterNames[this.ID].Trim().Length == 0)
                {
                    return "未知";
                }
                else
                {
                    return PkdFile.masterNames[this.ID];
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
                    return "未知系列";
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

        public short Unknow
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + UNKNOW_IDX);
            }
        }

        public short SheJi
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + SHEJI_IDX);
            }
            set
            {
                save(Index + SHEJI_IDX, value);
            }
        }

        public short GeDou
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + GEDOU_IDX);
            }
            set
            {
                save(Index + GEDOU_IDX, value);
            }
        }

        public short ShouBei
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + SHOUBEI_IDX);
            }
            set
            {
                save(Index + SHOUBEI_IDX, value);
            }
        }

        public short FanYin
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + FANYIN_IDX);
            }
            set
            {
                save(Index + FANYIN_IDX, value);
            }
        }

        public short JueXin
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + JUEXIN_IDX);
            }
            set
            {
                save(Index + JUEXIN_IDX, value);
            }
        }

        public short ZhiHui
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + ZHIHUI_IDX);
            }
            set
            {
                save(Index + ZHIHUI_IDX, value);
            }
        }

        public short FuZuo
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + FUZUO_IDX);
            }
            set
            {
                save(Index + FUZUO_IDX, value);
            }
        }

        public short TongXun
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + TONGXUN_IDX);
            }
            set
            {
                save(Index + TONGXUN_IDX, value);
            }
        }

        public short CaoDuo
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + CAODUO_IDX);
            }
            set
            {
                save(Index + CAODUO_IDX, value);
            }
        }

        public short WeiXiu
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + WEIXIU_IDX);
            }
            set
            {
                save(Index + WEIXIU_IDX, value);
            }
        }

        public short MeiLi
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + MEILI_IDX);
            }
            set
            {
                save(Index + MEILI_IDX, value);
            }
        }

        public short JinYan
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + JINYAN_IDX);
            }
            set
            {
                save(Index + JINYAN_IDX, value);
            }
        }

        public short ChengZhang
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + CHENGZHANG_IDX);
            }
            set
            {
                save(Index + CHENGZHANG_IDX, value);
            }
        }

        public short GuYou1
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + GUYOU1_IDX);
            }
            set
            {
                save(Index + GUYOU1_IDX, value);
            }
        }

        public short GuYou2
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + GUYOU2_IDX);
            }
            set
            {
                save(Index + GUYOU2_IDX, value);
            }
        }


        public short GuYou3
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + GUYOU3_IDX);
            }
            set
            {
                save(Index + GUYOU3_IDX, value);
            }
        }

        public short Last4
        {
            get
            {
                return BitConverter.ToInt16(PkdFile.Data, Index + LAST4_IDX);
            }
            set
            {
                save(Index + LAST4_IDX, value);
            }
        }


        public int CompareTo(MasterInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
