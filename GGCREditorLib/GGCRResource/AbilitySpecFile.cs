using GGCREditor;
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

        public AbilitySpecFile()
            : base(GGCRStaticConfig.AbilityFile)
        {
            //读取机体能力数量
            MachineAbilityCount = BitConverter.ToInt32(this.Data, 8);   //机体能力数量
            OPCount = BitConverter.ToInt32(this.Data, 12);              //OP数量
            PersonAbilityCount = BitConverter.ToInt32(this.Data, 16);   //个人技能数量
            WarAbilityCount = BitConverter.ToInt32(this.Data, 20);      //战场技能数量
            XiaoGuoCount = BitConverter.ToInt32(this.Data, 24);         //技能效果数量











        }


        public ReadOnlyCollection<string> ListMachineAbilitys()
        {
            //读取字符TBL
            List<string> list = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText();

            //读取机体能力
            List<string> machineAbilitys = new List<string>();
            for (int i = 0; i < MachineAbilityCount; i++)
            {
                machineAbilitys.Add(list[i]);
            }
            return machineAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListOPs()
        {
            //读取字符TBL

            List<string> list = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText();
            //读取OP
            List<string> ops = new List<string>();
            for (int i = MachineAbilityCount; i < MachineAbilityCount + OPCount; i++)
            {
                ops.Add(list[i]);
            }
            return ops.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListPersonAbilitys()
        {
            //读取字符TBL

            List<string> list = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText();
            //读取个人技能
            List<string> personAbilitys = new List<string>();
            for (int i = MachineAbilityCount + OPCount; i < MachineAbilityCount + OPCount + PersonAbilityCount; i++)
            {
                personAbilitys.Add(list[i]);
            }
            return personAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListWarAbilitys()
        {
            //读取字符TBL
            List<string> list = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText();
            //读取战场技能
            List<string> warAbilitys = new List<string>();
            for (int i = MachineAbilityCount + OPCount + PersonAbilityCount, j = MachineAbilityCount + OPCount + PersonAbilityCount; i < MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount; i++, j += 2)
            {
                warAbilitys.Add(list[j] + "(" + list[j + 1] + ")");
            }
            return warAbilitys.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListXiaoGuos()
        {
            //读取字符TBL
            List<string> list = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile).ListAllText();
            //技能效果
            List<string> xiaoguo = new List<string>();
            for (int i = MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount; i < MachineAbilityCount + OPCount + PersonAbilityCount + WarAbilityCount + XiaoGuoCount; i++)
            {
                xiaoguo.Add(list[i + WarAbilityCount]);
            }
            return xiaoguo.AsReadOnly();
        }
    }
}
