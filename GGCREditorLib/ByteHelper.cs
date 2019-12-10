using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GGCREditorLib
{
    public static class ByteHelper
    {

        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            }

            return buffer;
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
            }

            return sb.ToString().ToUpper();
        }

        public static int Bytes2Int(byte[] bytes)
        {
            return Bytes2Int(bytes, 0);
        }

        public static int Bytes2Int(byte[] bytes, int index)
        {
            int num = bytes[index + 3] & 0xFF;
            num |= ((bytes[index + 2] << 8) & 0xFF00);
            num |= ((bytes[index + 1] << 16) & 0xFF0000);
            num |= ((bytes[index + 0] << 24) & 0xFF0000);
            return num;
        }


        public static byte[] Int2Bytes(int i)
        {
            byte[] result = new byte[4];
            result[0] = (byte)((i >> 24) & 0xFF);
            result[1] = (byte)((i >> 16) & 0xFF);
            result[2] = (byte)((i >> 8) & 0xFF);
            result[3] = (byte)(i & 0xFF);
            return result;
        }

    }
}
