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

        public int XiaoGuoCount { get; }

        public ReadOnlyCollection<string> AbilityText { get; }

        public AbilitySpecFile()
            : base(GGCRStaticConfig.AbilityFile)
        {
            //读取机体能力数量
            MachineAbilityCount = BitConverter.ToInt32(this.Data, 8);   //机体能力数量
            OPCount = BitConverter.ToInt32(this.Data, 12);              //OP数量
            PersonAbilityCount = BitConverter.ToInt32(this.Data, 16);   //个人技能数量
            WarAbilityCount = BitConverter.ToInt32(this.Data, 20);      //战场技能数量
            XiaoGuoCount = BitConverter.ToInt32(this.Data, 24);         //技能效果数量

            //读取字符TBL
            AbilityText = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText().AsReadOnly();
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

            return list;

        }


        public ReadOnlyCollection<string> ListMachineAbilitys()
        {
            //读取机体能力
            List<string> machineAbilitys = new List<string>();
            for (int i = 0; i < MachineAbilityCount; i++)
            {
                machineAbilitys.Add(AbilityText[i]);
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
            for (int i = 0; i < WarAbilityCount; i++)
            {
                int skip = MachineAbilityCount + OPCount + PersonAbilityCount;
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
