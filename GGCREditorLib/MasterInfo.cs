using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 角色信息(112Byte)
    /// </summary>
    public class MasterInfo : IComparable<MasterInfo>
    {
        private MasterFile masterFile;

        /// <summary>
        /// 索引,以射击值为0
        /// </summary>
        public int Index { get; set; }

        private const int ID_IDX = -4;
        private const int UNKNOW_IDX = -2;
        private const int SHEJI_IDX = 0;
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

        public string MasterName { get; set; }

        public MasterInfo(MasterFile masterFile, int index)
        {
            this.masterFile = masterFile;
            this.Index = index;
        }

        public short ID
        {
            get
            {
                return BitConverter.ToInt16(masterFile.Data, Index + ID_IDX);
            }
        }

        public short Unknow
        {
            get
            {
                return BitConverter.ToInt16(masterFile.Data, Index + UNKNOW_IDX);
            }
        }

        public short SheJi
        {
            get
            {
                return BitConverter.ToInt16(masterFile.Data, Index + SHEJI_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + GEDOU_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + SHOUBEI_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + FANYIN_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + JUEXIN_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + ZHIHUI_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + FUZUO_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + TONGXUN_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + CAODUO_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + WEIXIU_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + MEILI_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + JINYAN_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + CHENGZHANG_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + GUYOU1_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + GUYOU2_IDX);
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
                return BitConverter.ToInt16(masterFile.Data, Index + GUYOU3_IDX);
            }
            set
            {
                save(Index + GUYOU3_IDX, value);
            }
        }



        private void save(int index, short value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                masterFile.Data[index + i] = arr[i];
            }
        }

        private void save(int index, int value)
        {
            byte[] arr = BitConverter.GetBytes(value);
            for (int i = 0; i < arr.Length; i++)
            {
                masterFile.Data[index + i] = arr[i];
            }
        }

        public int CompareTo(MasterInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
