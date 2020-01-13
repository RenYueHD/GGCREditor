using GGCREditor;
using GGCREditorLib.CDBItem;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.GGCRResource
{
    public class SpecProfileCdbFile : GGCRResourceFile
    {
        public SpecProfileCdbFile(string file) : base(GGCRStaticConfig.SpecProfileFile)
        {

        }

        public List<SpecProfileInfo> ListAll()
        {
            int total = BitConverter.ToInt32(this.Data, 8) + BitConverter.ToInt32(this.Data, 12) + BitConverter.ToInt32(this.Data, 16);

            List<SpecProfileInfo> list = new List<SpecProfileInfo>();
            for (int i = 0; i < total; i++)
            {
                list.Add(new SpecProfileInfo(this, 20 + i * 36, i));
            }
            return list;
        }
    }
}
