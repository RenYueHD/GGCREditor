using GGCREditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{
    public class XiaoGuoAbility : AbstractAbility
    {
        public XiaoGuoAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {
        }

        public override string TypeName => "技能效果";

        public override string UnitName
        {
            get
            {
                return "技能效果" + IDInGroup;
            }
        }

        public override short SkillId
        {
            get
            {
                return (short)(No - PkdFile.MachineAbilityCount - PkdFile.OPCount - PkdFile.PersonAbilityCount - PkdFile.WarAbilityCount * 2);
            }
            set
            {
                save(4, value);
            }
        }

        public int RemarkId
        {
            get
            {
                return this.No;
            }
        }
        public string RemarkDetail
        {
            get
            {
                return PkdFile.AbilityText[this.No];
            }
        }

        public override int IDInGroup => No - PkdFile.MachineAbilityCount - PkdFile.OPCount - PkdFile.PersonAbilityCount - PkdFile.WarAbilityCount * 2;

        public override int UnitLength => GGCRStaticConfig.XiaoGuoLength;
    }
}
