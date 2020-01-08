using GGCREditor;
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

        private string tempName;

        public override string UnitName
        {
            get
            {
                if (tempName != null)
                {
                    return tempName;
                }
                short idx = BitConverter.ToInt16(this.Data, 2);
                if (PkdFile.AbilityText.Count > idx)
                {
                    return PkdFile.AbilityText[BitConverter.ToInt16(this.Data, 2)];
                }
                else
                {
                    return null;
                }
            }
        }

        public void SetUnitName(string name)
        {
            this.tempName = name;
        }

        public abstract string TypeName { get; }

        public abstract int IDInGroup { get; }

        public virtual short SkillId
        {
            get
            {
                return BitConverter.ToInt16(this.Data, 4);
            }
            set
            {
                save(4, value);
            }
        }

        public override int UUID_START => 0;

        public override int UUID_LENGTH => 2;

        public override void Save()
        {
            if (tempName != null)
            {
                short idx = BitConverter.ToInt16(this.Data, 2);
                if (PkdFile.AbilityText.Count > idx)
                {
                    GGCRTblFile txtFile = new GGCRTblFile(GGCRStaticConfig.AbilityTxtFile);
                    List<string> list = txtFile.ListAllText();
                    if (list.Count > idx)
                    {
                        list[idx] = tempName;
                        txtFile.Save(list);

                        PkdFile.ReloadAbilityText();
                    }
                }
                tempName = null;
            }

            base.Save();
        }

    }
}
