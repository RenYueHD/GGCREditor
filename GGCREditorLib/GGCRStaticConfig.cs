using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditor
{
    public class GGCRStaticConfig
    {
        /// <summary>
        /// 系列单条长度
        /// </summary>
        public static int SeriesLength = 12;

        /// <summary>
        /// 驾驶员单条数据长度
        /// </summary>
        public static int MasterLength = 112;

        /// <summary>
        /// 机体单条数据长度
        /// </summary>
        public static int GundamLength = 108;

        /// <summary>
        /// 武器单条数据长度
        /// </summary>
        public static int WeaponLength = 36;

        /// <summary>
        /// 当前data目录
        /// </summary>
        public static string PATH { get; set; }

        public static string MachineFile
        {
            get
            {
                return PATH + "\\resident\\MachineSpecList.pkd";
            }
        }

        public static string MasterFile
        {
            get
            {
                return PATH + "\\resident\\CharacterSpecList.pkd";
            }
        }

        public static string AbilityFile
        {
            get
            {
                return PATH + "\\resident\\AbilitySpecList.cdb";
            }
        }

        public static string AbilityTxtFile
        {
            get
            {
                return PATH + @"\language\schinese\AbilitySpecList.tbl";
            }
        }

        public static string MachineTxtFile
        {
            get
            {
                return PATH + @"\language\schinese\MachineSpecList.tbl";
            }
        }

        public static string MasterTxtFile
        {
            get
            {
                return PATH + @"\language\schinese\\CharacterSpecList.tbl";
            }
        }
    }
}
