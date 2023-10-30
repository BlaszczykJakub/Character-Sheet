using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet_Rework.ViewModels
{
    partial class CharacterViewModel : BaseViewModel
    {
        // Abilities

        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                UpdateStrengthProperties();
            }
        }
        private void UpdateStrengthProperties()
        {
            OnPropertyChanged(nameof(Strength));
            OnPropertyChanged(nameof(StrengthMod));
            OnPropertyChanged(nameof(Athletics));
        }

        public int StrengthMod
        {
            get
            {
                return (int)Math.Floor((_strength - 10) / 2.0);
            }
        }
        public bool ProfStrength { get; set; }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                _dexterity = value;
                UpdateDexterityProperties();
            }
        }
        public int DexterityMod
        {
            get
            {
                return (int)Math.Floor((_dexterity - 10) / 2.0);
            }
        }
        private void UpdateDexterityProperties()
        {
            OnPropertyChanged(nameof(Dexterity));
            OnPropertyChanged(nameof(DexterityMod));
            OnPropertyChanged(nameof(Acrobatics));
            OnPropertyChanged(nameof(Sleight_of_Hand));
            OnPropertyChanged(nameof(Stealth));
        }
        public bool ProfDexterity { get; set; }

        private int _constitution;

        public int Constitution
        {
            get { return _constitution; }
            set
            {
                _constitution = value;
                UpdateConstitutionProperties();
            }
        }

        public int ConstitutionMod
        {
            get
            {
                return (int)Math.Floor((_constitution - 10) / 2.0);
            }
        }
        private void UpdateConstitutionProperties()
        {
            OnPropertyChanged(nameof(Constitution));
            OnPropertyChanged(nameof(ConstitutionMod));
        }
        public bool ProfConstitution { get; set; }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                _intelligence = value;
                UpdateIntelligenceProperties();
            }
        }
        public int IntelligenceMod
        {
            get
            {
                return (int)Math.Floor((_intelligence - 10) / 2.0);
            }
        }
        private void UpdateIntelligenceProperties()
        {
            OnPropertyChanged(nameof(Intelligence));
            OnPropertyChanged(nameof(IntelligenceMod));
            OnPropertyChanged(nameof(Arcana));
            OnPropertyChanged(nameof(History));
            OnPropertyChanged(nameof(Investigation));
            OnPropertyChanged(nameof(Nature));
            OnPropertyChanged(nameof(Religion));
        }
        public bool ProfIntelligence { get; set; }

        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                _wisdom = value;
                UpdateWisdomProperties();
            }
        }
        public int WisdomMod
        {
            get
            {
                return (int)Math.Floor((_wisdom - 10) / 2.0);
            }
        }
        private void UpdateWisdomProperties()
        {
            OnPropertyChanged(nameof(Wisdom));
            OnPropertyChanged(nameof(WisdomMod));
            OnPropertyChanged(nameof(Animal_Handling));
            OnPropertyChanged(nameof(Insight));
            OnPropertyChanged(nameof(Medicine));
            OnPropertyChanged(nameof(Perception));
            OnPropertyChanged(nameof(Survival));
        }
        public bool ProfWisdom { get; set; }

        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                _charisma = value;
                UpdateCharismaProperties();
            }

        }
        public int CharismaMod
        {
            get
            {
                return (int)Math.Floor((_charisma - 10) / 2.0);
            }
        }
        private void UpdateCharismaProperties()
        {
            OnPropertyChanged(nameof(Charisma));
            OnPropertyChanged(nameof(CharismaMod));
            OnPropertyChanged(nameof(Deception));
            OnPropertyChanged(nameof(Intimidation));
            OnPropertyChanged(nameof(Performance));
            OnPropertyChanged(nameof(Persuasion));
        }
        public bool ProfCharisma { get; set; }
    }
}
