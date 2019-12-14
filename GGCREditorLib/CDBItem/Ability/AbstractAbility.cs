using System;
using System.Collections.Generic;
using System.Text;

namespace GGCREditorLib.CDBItem.Ability
{

    /// <summary>
    /// 技能信息
    /// </summary>
    public abstract class AbstractAbility : GGCRUnitInfo<AbilitySpecFile>
    {
        public AbstractAbility(AbilitySpecFile file, int index, int no) : base(file, index, no)
        {

        }

        public override string UnitName
        {
            get
            {
                return PkdFile.AbilityText[No];
            }
        }

        public abstract int IDInGroup { get; }

        public short SkillId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 2);
            }
            set
            {
                save(2, value);
            }
        }

        public override int UUID_START => 0;

        public override int UUID_LENGTH => 2;

    }
}
