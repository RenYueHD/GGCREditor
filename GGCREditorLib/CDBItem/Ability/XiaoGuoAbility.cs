using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    public class XiaoGuoAbility : AbstractAbility
    {
        public XiaoGuoAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {
        }

        public short MachHP
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 2);
            }
            set
            {
                save(2, value);
            }
        }
        public short MachEN
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 4);
            }
            set
            {
                save(4, value);
            }
        }
        public short MachACT
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 6);
            }
            set
            {
                save(6, value);
            }
        }
        public short MachDEF
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 8);
            }
            set
            {
                save(8, value);
            }
        }
        public short MachSPD
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 10);
            }
            set
            {
                save(10, value);
            }
        }
        public short PowerSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 12);
            }
            set
            {
                save(12, value);
            }
        }
        public short PowerGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 14);
            }
            set
            {
                save(14, value);
            }
        }
        public short PowerWuLi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 16);
            }
            set
            {
                save(16, value);
            }
        }
        public short PowerBean
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 18);
            }
            set
            {
                save(18, value);
            }
        }
        public short PowerMap
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 20);
            }
            set
            {
                save(20, value);
            }
        }
        public short PowerZhanJianUnion
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 22);
            }
            set
            {
                save(22, value);
            }
        }
        public short PowerYouJiUnion
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 24);
            }
            set
            {
                save(24, value);
            }
        }

        public short PeoSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 26);
            }
            set
            {
                save(26, value);
            }
        }
        public short PeoGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 28);
            }
            set
            {
                save(28, value);
            }
        }
        public short PeoShouBei
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 30);
            }
            set
            {
                save(30, value);
            }
        }
        public short PeoFanYin
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 32);
            }
            set
            {
                save(32, value);
            }
        }
        public short PeoJueXin
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 34);
            }
            set
            {
                save(34, value);
            }
        }
        public short PeoZhiHui
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 36);
            }
            set
            {
                save(36, value);
            }
        }
        public short PeoFuZuo
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 38);
            }
            set
            {
                save(38, value);
            }
        }
        public short PeoTongXun
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 40);
            }
            set
            {
                save(40, value);
            }
        }
        public short PeoCaoDuo
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 42);
            }
            set
            {
                save(42, value);
            }
        }
        public short PeoWeiXiu
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 44);
            }
            set
            {
                save(44, value);
            }
        }
        public short PeoMeiLi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 46);
            }
            set
            {
                save(46, value);
            }
        }
        public short PeoZhanYiMP
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 48);
            }
            set
            {
                save(48, value);
            }
        }
        public short MachHPRec
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 50);
            }
            set
            {
                save(50, value);
            }
        }
        public short MachENRec
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 52);
            }
            set
            {
                save(52, value);
            }
        }
        public short JinYan
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 54);
            }
            set
            {
                save(54, value);
            }
        }
        public short JiFen
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 56);
            }
            set
            {
                save(56, value);
            }
        }
        public short Money
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 58);
            }
            set
            {
                save(58, value);
            }
        }
        public short DmgWuLiSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 60);
            }
            set
            {
                save(60, value);
            }
        }

        public short DmgWuLiGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 62);
            }
            set
            {
                save(62, value);
            }
        }

        public short DmgBeanSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 64);
            }
            set
            {
                save(64, value);
            }
        }
        public short DmgBeanGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 66);
            }
            set
            {
                save(66, value);
            }
        }
        public short DmgTeShuSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 68);
            }
            set
            {
                save(68, value);
            }
        }
        public short DmgTeShuGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 70);
            }
            set
            {
                save(70, value);
            }
        }

        public short DmgMap
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 72);
            }
            set
            {
                save(72, value);
            }
        }
        public short WuXiaoWuLiSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 74);
            }
            set
            {
                save(74, value);
            }
        }
        public short WuXiaoWuLiGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 76);
            }
            set
            {
                save(76, value);
            }
        }

        public short WuXiaoBeanSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 78);
            }
            set
            {
                save(78, value);
            }
        }
        public short WuXiaoBeanGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 80);
            }
            set
            {
                save(80, value);
            }
        }
        public short WuXiaoTeShuSheJi
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 82);
            }
            set
            {
                save(82, value);
            }
        }
        public short WuXiaoTeShuGeDou
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 84);
            }
            set
            {
                save(84, value);
            }
        }

        public short WuXiaoMap
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 86);
            }
            set
            {
                save(86, value);
            }
        }

        public short ShangHaiFinal
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 88);
            }
            set
            {
                save(88, value);
            }
        }
        public short ShangHaiFinalSelf
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 90);
            }
            set
            {
                save(90, value);
            }
        }

        public short UnKnow47
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 92);
            }
            set
            {
                save(92, value);
            }
        }
        public short UnKnow48
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 94);
            }
            set
            {
                save(94, value);
            }
        }
        public short UnKnow49
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 96);
            }
            set
            {
                save(96, value);
            }
        }
        public short UnKnow50
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 98);
            }
            set
            {
                save(98, value);
            }
        }

        public byte Mov
        {
            get
            {
                return this.Data[100];
            }
            set
            {
                save(100, value);
            }
        }
        public byte ShiYin1
        {
            get
            {
                return this.Data[101];
            }
            set
            {
                save(101, value);
            }
        }
        public byte ShiYin2
        {
            get
            {
                return this.Data[102];
            }
            set
            {
                save(102, value);
            }
        }
        public byte ShiYin3
        {
            get
            {
                return this.Data[103];
            }
            set
            {
                save(103, value);
            }
        }
        public byte ShiYin4
        {
            get
            {
                return this.Data[104];
            }
            set
            {
                save(104, value);
            }
        }
        public byte ShiYin5
        {
            get
            {
                return this.Data[105];
            }
            set
            {
                save(105, value);
            }
        }

        public byte SheChenSheJi
        {
            get
            {
                return this.Data[106];
            }
            set
            {
                save(106, value);
            }
        }
        public byte SheChenGeDou
        {
            get
            {
                return this.Data[107];
            }
            set
            {
                save(107, value);
            }
        }
        public byte SheChenWuLi
        {
            get
            {
                return this.Data[108];
            }
            set
            {
                save(108, value);
            }
        }
        public byte SheChenBean
        {
            get
            {
                return this.Data[109];
            }
            set
            {
                save(109, value);
            }
        }
        public byte SheChenMap
        {
            get
            {
                return this.Data[110];
            }
            set
            {
                save(110, value);
            }
        }

        public byte XiaoHaoEnSheJi
        {
            get
            {
                return this.Data[111];
            }
            set
            {
                save(111, value);
            }
        }
        public byte XiaoHaoEnGeDou
        {
            get
            {
                return this.Data[112];
            }
            set
            {
                save(112, value);
            }
        }
        public byte XiaoHaoEnWuLi
        {
            get
            {
                return this.Data[113];
            }
            set
            {
                save(113, value);
            }
        }
        public byte XiaoHaoEnBean
        {
            get
            {
                return this.Data[114];
            }
            set
            {
                save(114, value);
            }
        }
        public byte XiaoHaoEnMap
        {
            get
            {
                return this.Data[115];
            }
            set
            {
                save(115, value);
            }
        }
        public byte XiaoHaoMP
        {
            get
            {
                return this.Data[117];
            }
            set
            {
                save(117, value);
            }
        }

        public byte BaoJiSheJi
        {
            get
            {
                return this.Data[118];
            }
            set
            {
                save(118, value);
            }
        }
        public byte BaoJiGeDou
        {
            get
            {
                return this.Data[119];
            }
            set
            {
                save(119, value);
            }
        }
        public byte BaoJiWuLi
        {
            get
            {
                return this.Data[120];
            }
            set
            {
                save(120, value);
            }
        }
        public byte BaoJiBean
        {
            get
            {
                return this.Data[121];
            }
            set
            {
                save(121, value);
            }
        }
        public byte BaoJiUnKnow
        {
            get
            {
                return this.Data[122];
            }
            set
            {
                save(122, value);
            }
        }

        public byte MinZhong
        {
            get
            {
                return this.Data[123];
            }
            set
            {
                save(123, value);
            }
        }
        public byte ShanBi
        {
            get
            {
                return this.Data[124];
            }
            set
            {
                save(124, value);
            }
        }
        public byte UnKnow75
        {
            get
            {
                return this.Data[125];
            }
            set
            {
                save(125, value);
            }
        }

        public byte EWaiXinDong
        {
            get
            {
                return this.Data[126];
            }
            set
            {
                save(126, value);
            }
        }
        public byte AreaZhiHui
        {
            get
            {
                return this.Data[127];
            }
            set
            {
                save(127, value);
            }
        }
        public byte UnKnow78
        {
            get
            {
                return this.Data[128];
            }
            set
            {
                save(128, value);
            }
        }
        public byte AreaJiNen
        {
            get
            {
                return this.Data[129];
            }
            set
            {
                save(129, value);
            }
        }
        public short UnKnow80
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 130);
            }
            set
            {
                save(130, value);
            }
        }








        public override string TypeName => "技能效果";

        public override string UnitName
        {
            get
            {
                return "技能效果" + IDInGroup;
            }
        }

        public override short SkillId
        {
            get
            {
                return (short)(No - PkdFile.MachineAbilityCount - PkdFile.OPCount - PkdFile.PersonAbilityCount - PkdFile.WarAbilityCount * 2);
            }
            set
            {
                throw new Exception("技能效果的效果编号无法修改");
            }
        }

        public short RemarkId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 0);
            }
            set
            {
                save(0, value);
            }
        }

        private string tempRemark;

        public override void Save()
        {
            string tmp = tempRemark;
            this.tempRemark = null;
            if (tmp != null && tmp != RemarkDetail)
            {
                GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile);
                List<string> list = txtFile.ListAllText();
                if (list.Count > this.RemarkId)
                {
                    list[this.RemarkId] = tmp;
                    txtFile.Save(list);

                    PkdFile.ReloadAbilityText();
                }

            }
            base.Save();
        }
        public string RemarkDetail
        {
            get
            {
                if (PkdFile.AbilityText.Count > this.RemarkId)
                {
                    return tempRemark ?? PkdFile.AbilityText[this.RemarkId];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.tempRemark = value;
            }
        }

        public override int IDInGroup => No - PkdFile.MachineAbilityCount - PkdFile.OPCount - PkdFile.PersonAbilityCount - PkdFile.WarAbilityCount * 2;

        public override int UnitLength => GGCRStaticConfig.XiaoGuoLength;
    }
}
