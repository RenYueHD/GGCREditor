using GGCREditor;
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
        public const int ID_IDX = GROUP_IDX + 28;
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

        private List<MasterInfo> all;

        public MasterInfo(MasterFile File, int index, int no, List<MasterInfo> all)
            : base(File, index, no)
        {
            this.all = all;
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

        public override string UnitName
        {
            get
            {
                if (this.Group == 9990)
                {
                    return "自定角色(生日月/日个位和=" + (this.Data[6] - 1) + ")";
                }
                if (this.ID < 0 || PkdFile.MasterNames[this.ID] == null || PkdFile.MasterNames[this.ID].Trim().Length == 0)
                {
                    return "未知";
                }
                else
                {
                    if (this.Data[LAST4_IDX] == 1)
                    {
                        int nextId = 99999;
                        //寻找下一个人的最小索引
                        foreach (MasterInfo m in this.all)
                        {
                            if (m.Index > this.Index)
                            {
                                if (nextId > m.ID)
                                {
                                    nextId = m.ID;
                                }
                            }
                        }
                        if (nextId != 99999)
                        {
                            //从当前ID到minId的所有名字都为此人
                            int startId = this.ID;
                            int endId = nextId - 1;
                            if (endId - startId > 0)
                            {
                                return PkdFile.MasterNames[this.ID + 1];
                            }
                            else
                            {
                                return PkdFile.MasterNames[this.ID];
                            }
                        }
                        else
                        {
                            //为最后一个
                            return PkdFile.MasterNames[this.ID];
                        }
                    }
                    else
                    {
                        return PkdFile.MasterNames[this.ID];
                    }
                }
            }
        }

        public override void SaveUnitName(string name)
        {
            throw new Exception("不允许直接修改人物数据");
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

        public short Unknow
        {
            get
            {
                return BitConverter.ToInt16(this.Data, UNKNOW_IDX);
            }
        }

        public short SheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SHEJI_IDX);
            }
            set
            {
                save(SHEJI_IDX, value);
            }
        }

        public short GeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, GEDOU_IDX);
            }
            set
            {
                save(GEDOU_IDX, value);
            }
        }

        public short ShouBei
        {
            get
            {
                return BitConverter.ToInt16(this.Data, SHOUBEI_IDX);
            }
            set
            {
                save(SHOUBEI_IDX, value);
            }
        }

        public short FanYin
        {
            get
            {
                return BitConverter.ToInt16(this.Data, FANYIN_IDX);
            }
            set
            {
                save(FANYIN_IDX, value);
            }
        }

        public short JueXin
        {
            get
            {
                return BitConverter.ToInt16(this.Data, JUEXIN_IDX);
            }
            set
            {
                save(JUEXIN_IDX, value);
            }
        }

        public short ZhiHui
        {
            get
            {
                return BitConverter.ToInt16(this.Data, ZHIHUI_IDX);
            }
            set
            {
                save(ZHIHUI_IDX, value);
            }
        }

        public short FuZuo
        {
            get
            {
                return BitConverter.ToInt16(this.Data, FUZUO_IDX);
            }
            set
            {
                save(FUZUO_IDX, value);
            }
        }

        public short TongXun
        {
            get
            {
                return BitConverter.ToInt16(this.Data, TONGXUN_IDX);
            }
            set
            {
                save(TONGXUN_IDX, value);
            }
        }

        public short CaoDuo
        {
            get
            {
                return BitConverter.ToInt16(this.Data, CAODUO_IDX);
            }
            set
            {
                save(CAODUO_IDX, value);
            }
        }

        public short WeiXiu
        {
            get
            {
                return BitConverter.ToInt16(this.Data, WEIXIU_IDX);
            }
            set
            {
                save(WEIXIU_IDX, value);
            }
        }

        public short MeiLi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, MEILI_IDX);
            }
            set
            {
                save(MEILI_IDX, value);
            }
        }

        public short JinYan
        {
            get
            {
                return BitConverter.ToInt16(this.Data, JINYAN_IDX);
            }
            set
            {
                save(JINYAN_IDX, value);
            }
        }

        public short ChengZhang
        {
            get
            {
                return BitConverter.ToInt16(this.Data, CHENGZHANG_IDX);
            }
            set
            {
                save(CHENGZHANG_IDX, value);
            }
        }

        public short GuYou1
        {
            get
            {
                return BitConverter.ToInt16(this.Data, GUYOU1_IDX);
            }
            set
            {
                save(GUYOU1_IDX, value);
            }
        }

        public short GuYou2
        {
            get
            {
                return BitConverter.ToInt16(this.Data, GUYOU2_IDX);
            }
            set
            {
                save(GUYOU2_IDX, value);
            }
        }


        public short GuYou3
        {
            get
            {
                return BitConverter.ToInt16(this.Data, GUYOU3_IDX);
            }
            set
            {
                save(GUYOU3_IDX, value);
            }
        }

        public short Last4
        {
            get
            {
                return BitConverter.ToInt16(this.Data, LAST4_IDX);
            }
            set
            {
                save(LAST4_IDX, value);
            }
        }

        public override int UnitLength
        {
            get
            {
                return GGCRStaticConfig.MasterLength;
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
                return GGCRStaticConfig.MasterUIDLength;
            }
        }

        public int CompareTo(MasterInfo other)
        {
            return this.Index - other.Index;
        }
    }
}
