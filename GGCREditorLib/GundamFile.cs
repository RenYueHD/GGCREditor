using GGCREditor;
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

        internal Dictionary<string, string> groups;
        internal string[] weaponNames;
        internal string[] gundamName;

        public GundamFile()
            : base(GGCRStaticConfig.MachineFile)
        {
            groups = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader("系列代码.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        groups[arr[1]] = arr[0];
                    }
                }
            }

            byte[] data = File.ReadAllBytes(GGCRStaticConfig.MachineTxtFile);
            int idx = ByteHelper.FindFirstIndex(data, "E5 85 89 E6 9D 9F E5 86", 0);

            weaponNames = Encoding.UTF8.GetString(data, idx, data.Length - idx).Split('\0');

            idx = ByteHelper.FindFirstIndex(data, "E9 A3 9E E7 BF BC E9 AB", 0);
            gundamName = Encoding.UTF8.GetString(data, idx, data.Length - idx).Split('\0');
        }

        /// <summary>
        /// 获取所有Master
        /// </summary>
        /// <returns></returns>
        public List<GundamInfo> ListMachines()
        {
            int start = ByteHelper.FindFirstIndex(this.Data, "4C 53 43 4D", 0);
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);
            int count2 = BitConverter.ToInt32(this.Data, start + 12);

            List<GundamInfo> list = new List<GundamInfo>();
            for (int i = 0; i < count + count2; i++)
            {
                list.Add(new GundamInfo(this, start + 32 + i * GGCRStaticConfig.GundamLength, i));
            }
            return list;
        }

        public List<WeaponInfo> ListWeapons()
        {
            int start = ByteHelper.FindFirstIndex(this.Data, "4C 53 50 57", 0);
            if (start < 0)
            {
                throw new Exception("文件[" + this.FileName + "]无法解析");
            }

            int count = BitConverter.ToInt32(this.Data, start + 8);
            int count2 = BitConverter.ToInt32(this.Data, start + 12);

            List<WeaponInfo> list = new List<WeaponInfo>();
            for (int i = 0; i < count + count2; i++)
            {
                list.Add(new WeaponInfo(this, start + 28 + i * GGCRStaticConfig.WeaponLength, i));
            }
            return list;
        }

    }
}
