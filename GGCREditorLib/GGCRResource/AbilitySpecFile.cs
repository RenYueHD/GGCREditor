using GGCREditor;
using GGCREditorLib.CDBItem;
using GGCREditorLib.CDBItem.Ability;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 角色文件数据
    /// </summary>
    public class AbilitySpecFile : GGCRPkdFile
    {

        public int MachineAbilityCount { get; }
        public int OPCount { get; }
        public int PersonAbilityCount { get; }

        public int WarAbilityCount { get; }

        private int xiaoguoCount;
        public int XiaoGuoCount { get { return xiaoguoCount; } }

        private ReadOnlyCollection<string> abilityText;
        public ReadOnlyCollection<string> AbilityText { get { return abilityText; } }

        public AbilitySpecFile()
            : base(GGCRStaticConfig.AbilityFile)
        {
            //读取机体能力数量
            MachineAbilityCount = BitConverter.ToInt32(this.Data, 8);   //机体能力数量
            OPCount = BitConverter.ToInt32(this.Data, 12);              //OP数量
            PersonAbilityCount = BitConverter.ToInt32(this.Data, 16);   //个人技能数量
            WarAbilityCount = BitConverter.ToInt32(this.Data, 20);      //战场技能数量
            this.xiaoguoCount = BitConverter.ToInt32(this.Data, 24);         //技能效果数量

            ReloadAbilityText();
        }

        public void ReloadAbilityText()
        {
            //读取字符TBL
            abilityText = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText().AsReadOnly();
        }

        public void CopyAndCreate(AbstractAbility ability)
        {
            if (ability is XiaoGuoAbility)
            {
                copyAndCreate((XiaoGuoAbility)ability);
            }
            else
            {
                byte[] data = new byte[ability.Data.Length];
                ability.Data.CopyTo(data, 0);

                int count = -1;
                if (ability is GundamAbility)
                {
                    count = addText("自创机体能力");
                    BitConverter.GetBytes((short)(BitConverter.ToInt32(this.Data, 8) + 1)).CopyTo(this.Data, 8);
                }
                else if (ability is PersonAbility)
                {
                    count = addText("自创人物技能");
                    BitConverter.GetBytes((short)(BitConverter.ToInt32(this.Data, 16) + 1)).CopyTo(this.Data, 16);
                }
                else if (ability is OPInfo)
                {
                    count = addText("自创OP");
                    BitConverter.GetBytes((short)(BitConverter.ToInt32(this.Data, 12) + 1)).CopyTo(this.Data, 12);
                }
                else
                {
                    throw new Exception("不支持此物品复制");
                }

                BitConverter.GetBytes((short)(count - 1)).CopyTo(data, 2);

                this.Insert(ability.Index + ability.UnitLength, data);
            }
        }

        private void copyAndCreate(XiaoGuoAbility ability)
        {
            int count = addText("我的自创技能效果");

            byte[] newXiaoGuo = new byte[ability.Data.Length];
            ability.Data.CopyTo(newXiaoGuo, 0);
            Array.Copy(BitConverter.GetBytes((short)(count - 1)), newXiaoGuo, 2);

            this.xiaoguoCount++;
            base.Write(24, BitConverter.GetBytes(xiaoguoCount));
            base.Write(this.Data.Length, newXiaoGuo);
        }

        private int addText(string text)
        {
            int count = 0;
            foreach (string s in GGCRUtil.Languages())
            {
                GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.PATH + @"\language\" + s + @"\AbilitySpecList.tbl");
                if (txtFile.Count > count)
                {
                    count = txtFile.Count;
                }
            }
            count++;
            foreach (string s in GGCRUtil.Languages())
            {
                GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.PATH + @"\language\" + s + @"\AbilitySpecList.tbl");
                List<string> list = txtFile.ListAllText();
                int span = count - list.Count;
                for (int i = 0; i < span; i++)
                {
                    list.Add(text);
                }
                txtFile.Save(list);
            }
            return count;
        }

        public List<AbstractAbility> ListAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;
            //读取机体技能
            List<AbstractAbility> list = new List<AbstractAbility>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                list.Add(new GundamAbility(this, idx, no));
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }
            for (int i = 0; i < OPCount; i++)
            {
                list.Add(new OPInfo(this, idx, no));
                idx += GGCRStaticConfig.OPAbilityLength;
                no++;
            }
            for (int i = 0; i < PersonAbilityCount; i++)
            {
                list.Add(new PersonAbility(this, idx, no));
                idx += GGCRStaticConfig.PeopleAbilityLength;
                no++;
            }
            for (int i = 0; i < WarAbilityCount; i++)
            {
                list.Add(new WarAbility(this, idx, no));
                idx += GGCRStaticConfig.WarAbilityLength;
                no += 2;
            }
            for (int i = 0; i < XiaoGuoCount; i++)
            {
                list.Add(new XiaoGuoAbility(this, idx, no));
                idx += GGCRStaticConfig.XiaoGuoLength;
                no++;
            }

            return list;
        }

        public List<XiaoGuoAbility> ListXiaoGuo()
        {
            int idx = GGCRStaticConfig.GundamAbilityStart;
            //读取机体技能
            List<XiaoGuoAbility> list = new List<XiaoGuoAbility>();

            int skipIndx = GGCRStaticConfig.GundamAbilityStart + MachineAbilityCount * GGCRStaticConfig.GundamAbilityLength
                + OPCount * GGCRStaticConfig.OPAbilityLength + PersonAbilityCount * GGCRStaticConfig.PeopleAbilityLength
                + WarAbilityCount * GGCRStaticConfig.WarAbilityLength;
            int skipLength = MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount * 2;

            for (int i = 0; i < XiaoGuoCount; i++)
            {
                list.Add(new XiaoGuoAbility(this, skipIndx + i * GGCRStaticConfig.XiaoGuoLength, skipLength + i));
            }

            return list;
        }

        public ReadOnlyCollection<string> ListMachineAbilitys()
        {
            int no = 0;
            int idx = GGCRStaticConfig.GundamAbilityStart;

            //读取机体能力
            List<string> machineAbilitys = new List<string>();

            for (int i = 0; i < MachineAbilityCount; i++)
            {
                machineAbilitys.Add(new GundamAbility(this, idx, no).UnitName);
                idx += GGCRStaticConfig.GundamAbilityLength;
                no++;
            }

            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListOPs()
        {
            //读取OP
            List<string> ops = new List<string>();
            for (int i = 0; i < OPCount; i++)
            {
                ops.Add(AbilityText[i + MachineAbilityCount]);
            }
            return ops.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListPersonAbilitys()
        {
            //读取个人技能
            List<string> personAbilitys = new List<string>();
            for (int i = 0; i < PersonAbilityCount; i++)
            {
                personAbilitys.Add(AbilityText[i + MachineAbilityCount + OPCount]);
            }
            return personAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListWarAbilitys()
        {
            //读取战场技能
            List<string> warAbilitys = new List<string>();
            int skip = MachineAbilityCount + OPCount + PersonAbilityCount;
            for (int i = 0; i < WarAbilityCount; i++)
            {
                warAbilitys.Add(AbilityText[skip + i * 2] + "(" + AbilityText[skip + i * 2 + 1] + ")");
            }
            return warAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListXiaoGuos()
        {
            //技能效果
            List<string> xiaoguo = new List<string>();
            for (int i = MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount; i < MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount + XiaoGuoCount; i++)
            {
                xiaoguo.Add(AbilityText[i + WarAbilityCount]);
            }
            return xiaoguo.AsReadOnly();
        }
    }
}
