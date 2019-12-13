using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditor
{
    public static class GGCRUtil
    {

        #region 人物部分
        public static List<KeyValuePair<string, string>> ListPeopleSkill()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("固有技能.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        prop.Add(kv);
                    }
                }
            }
            return prop;
        }

        public static void AddPeopleSkill(short value, string skill)
        {
            using (StreamWriter sr = new StreamWriter("固有技能.txt", true))
            {
                sr.WriteLine();
                sr.Write(value + ":" + skill);
                sr.Flush();
            }
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
        public static List<KeyValuePair<string, string>> ListGundamAbility()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("机体能力.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> info = new KeyValuePair<string, string>(arr[0], arr[1]);
                        prop.Add(info);
                    }
                }
            }
            return prop;
        }
        public static void AddGundamAbility(short value, string prop)
        {
            using (StreamWriter sr = new StreamWriter("机体能力.txt", true))
            {
                sr.WriteLine();
                sr.Write(value + ":" + prop);
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

        public static List<KeyValuePair<string, string>> ListWeaponProp()
        {
            List<KeyValuePair<string, string>> prop = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("武器属性.txt"))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string[] arr = line.Split(':');
                        KeyValuePair<string, string> kv = new KeyValuePair<string, string>(arr[0], arr[1]);
                        prop.Add(kv);
                    }
                }
            }
            return prop;
        }

        public static void AddWeaponProp(byte value, string prop)
        {
            using (StreamWriter sr = new StreamWriter("武器属性.txt", true))
            {
                sr.WriteLine();
                sr.Write(value + ":" + prop);
                sr.Flush();
            }
        }

        public static List<KeyValuePair<string, string>> ListWeaponSpec()
        {
            List<KeyValuePair<string, string>> spec = new List<KeyValuePair<string, string>>();

            using (StreamReader sr = new StreamReader("武器效果.txt"))
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

        public static void AddWeaponSpec(short value, string spec)
        {
            using (StreamWriter sr = new StreamWriter("武器效果.txt", true))
            {
                sr.WriteLine();
                sr.Write(value + ":" + spec);
                sr.Flush();
            }
        }


        public static List<KeyValuePair<string, string>> ListWeaponRange()
        {
            List<KeyValuePair<string, string>> range = new List<KeyValuePair<string, string>>();
            string line = null;

            using (StreamReader sr = new StreamReader("射程代码.txt"))
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
            using (StreamWriter sr = new StreamWriter("射程代码.txt", true))
            {
                sr.WriteLine();
                sr.Write(value + ":" + range);
                sr.Flush();
            }
        }

        #endregion

    }
}
