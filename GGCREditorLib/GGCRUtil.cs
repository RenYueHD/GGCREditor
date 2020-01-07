using GGCREditorLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditor
{
    public static class GGCRUtil
    {
        #region 系列部分
        public static Dictionary<short, string> ListSeriesCode()
        {
            Dictionary<short, string> dic = new Dictionary<short, string>();

            List<string> names = new GGCRTblFile(GGCRStaticConfig.PATH + @"\language\" + GGCRStaticConfig.Language + @"\MiscData.tbl").ListAllText();

            GGCRPkdFile misc = new GGCRPkdFile(GGCRStaticConfig.PATH + @"\resident\MiscData.pkd");

            int idx = misc.GetInnerFile("SeriesList.cdb").StartIndex;
            int count = BitConverter.ToInt32(misc.Data, idx + 8);
            for (int i = 0; i < count; i++)
            {
                short groupId = BitConverter.ToInt16(misc.Data, idx + 12 + i * GGCRStaticConfig.SeriesLength);
                dic.Add(groupId, names[i]);
            }
            return dic;
        }

        #endregion

        #region 人物部分

        public static List<KeyValuePair<string, string>> ListMasterZhaoPin()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("招聘可能.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddMasterZhaoPin(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("招聘可能.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListMasterGrown()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("成长规律.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddMasterGrown(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("成长规律.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        private static List<KeyValuePair<string, string>> peopleSkillExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListPeopleSkill()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            IList<string> list = new AbilitySpecFile().ListPersonAbilitys();

            prop.Add(new KeyValuePair<string, string>("-1", "-1:无"));
            for (int i = 0; i < list.Count; i++)
            {
                prop.Add(new KeyValuePair<string, string>(i.ToString(), i + ":" + list[i]));
            }
            prop.AddRange(peopleSkillExt);
            return prop;
        }

        public static void AddPeopleSkill(short value, string skill)
        {
            peopleSkillExt.Add(new KeyValuePair<string, string>(value.ToString(), skill));
        }
        #endregion

        #region 机体部分
        private static List<KeyValuePair<string, string>> sizeExt = new List<KeyValuePair<string, string>>();
        private static List<KeyValuePair<string, string>> gundamEarthExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListGundamSize()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("1", "S"));
            list.Add(new KeyValuePair<string, string>("2", "M"));
            list.Add(new KeyValuePair<string, string>("3", "L"));
            list.Add(new KeyValuePair<string, string>("5", "XL"));
            list.Add(new KeyValuePair<string, string>("6", "XXL"));
            list.AddRange(sizeExt);
            return list;
        }
        public static void AddGundamSize(short value, string size)
        {
            sizeExt.Add(new KeyValuePair<string, string>(value.ToString(), size));
        }

        public static List<KeyValuePair<string, string>> ListGundamEarth()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "-"));
            list.Add(new KeyValuePair<string, string>("1", "D"));
            list.Add(new KeyValuePair<string, string>("2", "C"));
            list.Add(new KeyValuePair<string, string>("3", "B"));
            list.Add(new KeyValuePair<string, string>("4", "A"));
            list.Add(new KeyValuePair<string, string>("5", "S"));
            list.AddRange(gundamEarthExt);
            return list;
        }
        public static void AddGundamEarth(short value, string earth)
        {
            gundamEarthExt.Add(new KeyValuePair<string, string>(value.ToString(), earth));
        }

        private static List<KeyValuePair<string, string>> machineAbilityExt = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> ListGundamAbility()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            IList<string> list = new AbilitySpecFile().ListMachineAbilitys();

            prop.Add(new KeyValuePair<string, string>("-1", "-1:无"));
            for (int i = 0; i < list.Count; i++)
            {
                prop.Add(new KeyValuePair<string, string>(i.ToString(), i + ":" + list[i]));
            }
            prop.AddRange(machineAbilityExt);
            return prop;
        }
        public static void AddGundamAbility(short value, string prop)
        {
            machineAbilityExt.Add(new KeyValuePair<string, string>(value.ToString(), prop));
        }


        public static List<KeyValuePair<string, string>> ListConvertAction()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("换装动作.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddConvertAction(int value, string range)
        {
            using (StreamWriter sr = new StreamWriter("换装动作.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListEarthSize()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("占地面积.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddEarthSize(int value, string range)
        {
            using (StreamWriter sr = new StreamWriter("占地面积.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }
        #endregion

        #region 武器部分
        private static List<KeyValuePair<string, string>> mpLimitExt = new List<KeyValuePair<string, string>>();

        public static List<KeyValuePair<string, string>> ListActEarch()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("00", "无效"));
            list.Add(new KeyValuePair<string, string>("01", "减半"));
            list.Add(new KeyValuePair<string, string>("10", "正常"));
            return list;
        }

        public static List<KeyValuePair<string, string>> ListWeaponMPLimit()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("0", "普通"));
            list.Add(new KeyValuePair<string, string>("4", "超强势"));
            list.Add(new KeyValuePair<string, string>("5", "超一击"));
            list.AddRange(mpLimitExt);
            return list;
        }

        public static void AddWeaponMPLimit(short value, string limit)
        {
            mpLimitExt.Add(new KeyValuePair<string, string>(value.ToString(), limit));
        }

        public static List<KeyValuePair<string, string>> ListWeaponRange()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("射程代码.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        range.Add(kv);
                    }
                }
            }
            return range;
        }

        public static void AddWeaponRange(short value, string range)
        {
            using (StreamWriter sr = new StreamWriter("射程代码.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListWeaponType()
        {
            List<KeyValuePair<string, string>> spec = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("武器类型.txt", Encoding.UTF8))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        spec.Add(kv);
                    }
                }
            }
            return spec;
        }

        public static void AddWeaponType(byte value, string type)
        {
            using (StreamWriter sr = new StreamWriter("武器类型.txt", true, Encoding.UTF8))
            {
                sr.WriteLine();
                sr.Write(value + ":" + type);
                sr.Flush();
            }
        }

        #endregion


        public static string Transform(List<KeyValuePair<string, string>> list, string key)
        {
            foreach (KeyValuePair<string, string> kv in list)
            {
                if (kv.Key == key)
                {
                    return kv.Value;
                }
            }
            return "未知";
        }


        public static string[] Languages()
        {
            return new string[] { "schinese", "tchinese/hk", "tchinese/tw", "japanese", "english", "korean" };
        }
    }
}
