﻿using GGCREditor;
using GGCREditorLib.CDBItem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    /// <summary>
    /// 机体文件数据
    /// </summary>
    public class GundamFile : GGCRPkdFile
    {

        public Dictionary<short, string> SeriesCode { get; }
        internal string[] WeaponNames;
        internal string[] GundamName { get; }

        internal List<string> AllText { get; }

        //高达CDB起始
        public int GundamCdbStart { get; }
        //高达数
        public int GundamCount { get; }
        //战舰数
        public int ShipCount { get; }
        //武器在CDB中的起始
        public int WeaponCdbStart { get; }
        //武器属性在CDB中的起始
        public int PropCdbStart { get; }
        //武器属性数量
        public int PropCount { get; }
        //武器效果在CDB中的起始
        public int SpecCdbStart { get; }
        //武器效果数量
        public int SpecCount { get; }

        public int WeaponNormalCount { get; }
        public int WeaponMapCount { get; }

        public GundamFile()
            : base(GGCRStaticConfig.MachineFile)
        {
            this.SeriesCode = GGCRUtil.ListSeriesCode();

            GundamCdbStart = this.GetInnerFile("MachineSpecList.cdb").StartIndex;
            GundamCount = BitConverter.ToInt32(this.Data, GundamCdbStart + 8);
            ShipCount = BitConverter.ToInt32(this.Data, GundamCdbStart + 12);

            WeaponCdbStart = this.GetInnerFile("WeaponSpecList.cdb").StartIndex;
            if (WeaponCdbStart < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }
            WeaponNormalCount = BitConverter.ToInt32(this.Data, WeaponCdbStart + 8);
            WeaponMapCount = BitConverter.ToInt32(this.Data, WeaponCdbStart + 12);

            this.WeaponNames = new string[WeaponNormalCount + WeaponMapCount];
            this.AllText = new GGCRTblFile(GGCRStaticConfig.MachineTxtFile).ListAllText();
            AllText.CopyTo(0, WeaponNames, 0, WeaponNames.Length);

            //计算属性数据索引
            PropCdbStart = WeaponCdbStart + 28 + (WeaponNormalCount + WeaponMapCount) * GGCRStaticConfig.WeaponLength;
            PropCount = BitConverter.ToInt32(this.Data, PropCdbStart);

            SpecCdbStart = PropCdbStart + 4 + PropCount * 4;
            SpecCount = BitConverter.ToInt32(this.Data, SpecCdbStart);

            this.GundamName = new string[GundamCount + ShipCount];
            AllText.CopyTo(WeaponNormalCount + WeaponMapCount + PropCount + SpecCount * 2, GundamName, 0, GundamCount + ShipCount);
        }

        public List<KeyValuePair<string, string>> ListWeaponProp()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < PropCount; i++)
            {
                short nameIndex = BitConverter.ToInt16(this.Data, PropCdbStart + 4 + i * 4);
                string name = this.AllText[nameIndex];
                short value = BitConverter.ToInt16(this.Data, PropCdbStart + 4 + 2 + i * 4);

                list.Add(new KeyValuePair<string, string>(value.ToString(), name));
            }
            return list;
        }

        public List<KeyValuePair<string, string>> ListWeaponSpec()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < SpecCount; i++)
            {
                short nameIndex = BitConverter.ToInt16(this.Data, SpecCdbStart + 4 + i * 6);
                string name = this.AllText[nameIndex];
                short value = BitConverter.ToInt16(this.Data, SpecCdbStart + 4 + 4 + i * 6);

                list.Add(new KeyValuePair<string, string>(value.ToString(), name));
            }
            return list;
        }

        /// <summary>
        /// 获取所有机体
        /// </summary>
        /// <returns></returns>
        public List<GundamInfo> ListMachines()
        {
            int start = GundamCdbStart;
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            List<GundamInfo> list = new List<GundamInfo>();
            for (int i = 0; i < GundamCount + ShipCount; i++)
            {
                list.Add(new GundamInfo(this, start + 32 + i * GGCRStaticConfig.GundamLength, i));
            }
            return list;
        }

        public List<WeaponInfo> ListWeapons()
        {
            List<WeaponInfo> list = new List<WeaponInfo>();
            for (int i = 0; i < WeaponNormalCount + WeaponMapCount; i++)
            {
                if (i < WeaponNormalCount)
                {
                    list.Add(new WeaponNormalInfo(this, WeaponCdbStart + 28 + i * GGCRStaticConfig.WeaponLength, i));
                }
                else
                {
                    list.Add(new WeaponMapInfo(this, WeaponCdbStart + 28 + i * GGCRStaticConfig.WeaponLength, i));
                }

            }
            return list;
        }


        public List<MachineConvertInfo> ListConvert()
        {
            int start = this.GetInnerFile("MachineConversionList.cdb").StartIndex;
            int count = BitConverter.ToInt32(this.Data, start + 8);

            int firstIndex = start + 12;

            List<MachineConvertInfo> list = new List<MachineConvertInfo>();

            for (int i = 0; i < count; i++)
            {
                MachineConvertInfo convert = new MachineConvertInfo(this, firstIndex + i * 20, i);

                list.Add(convert);
            }
            return list;
        }
    }
}
