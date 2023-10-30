using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet_Rework.ViewModels
{
    partial class CharacterViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public string Playername { get; set; }
        public int ExperiencePoints { get; set; }

        private int _proficiency;

        public int Proficiency
        {
            get { return _proficiency; }
            set { 
                _proficiency = value;
                UpdateStrengthProperties();
                UpdateDexterityProperties();
                UpdateConstitutionProperties();
                UpdateIntelligenceProperties();
                UpdateWisdomProperties();
                UpdateCharismaProperties();
            }
        }

        public string HitDice { get; set; }
        public int MaxHitPoints {  get; set; }
        public int CurrentHitPoints { get; set; }
        public int TemporaryHitPoints { get; set; }
        public int Speed { get; set; }
        public int Initiative { get; set; }
        public int ArmorClass { get; set; }
        public bool Inspiration { get; set; }

        public bool DeathSaveFail0 { get; set; }
        public bool DeathSaveFail1 { get; set; }
        public bool DeathSaveFail2 { get; set; }

        public bool DeathSaveSuccess0 { get; set; }
        public bool DeathSaveSuccess1 { get; set; }
        public bool DeathSaveSuccess2 { get; set; }

        public ObservableCollection<string> ArmorProf { get; set; }
        public ObservableCollection<string> WeaponProf { get; set; }
        public ObservableCollection<string> ToolProf { get; set; } 
        public ObservableCollection<string> LanguageProf { get; set; }

        public CharacterViewModel()
        {
            ArmorProf = new();
            WeaponProf = new();
            ToolProf = new();
            LanguageProf = new();
        }
    }
}
