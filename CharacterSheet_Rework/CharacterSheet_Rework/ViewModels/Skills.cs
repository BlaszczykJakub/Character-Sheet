using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet_Rework.ViewModels
{
    partial class CharacterViewModel : BaseViewModel
    {
        // Skills
        private bool _profAcrobatics;
        public bool ProfAcrobatics
        {
            get { return _profAcrobatics; }
            set
            {
                _profAcrobatics = value;
                OnPropertyChanged(nameof(Acrobatics));
            }
        }
        public int Acrobatics
        {
            get
            {
                return DexterityMod + (_profAcrobatics ? _proficiency : 0);
            }
        }

        private bool _profAnimal_Handling;
        public bool ProfAnimal_Handling
        {
            get { return _profAnimal_Handling; }
            set { 
                _profAnimal_Handling = value;
                OnPropertyChanged(nameof(Animal_Handling));
            }
        }
        public int Animal_Handling
        {
            get
            {
                return WisdomMod + (_profAnimal_Handling ? _proficiency : 0);
            }
        }

        private bool _profArcana;
        public bool ProfArcana
        {
            get { return _profArcana; }
            set { _profArcana = value;
                OnPropertyChanged(nameof(Arcana));
            }
        }
        public int Arcana
        {
            get
            {
                return IntelligenceMod + (_profArcana ? _proficiency : 0);
            }
        }

        private bool _profAthletics;
        public bool ProfAthletics
        {
            get { return _profAthletics; }
            set { _profAthletics = value;
                OnPropertyChanged(nameof(Athletics));
            }
        }
        public int Athletics
        {
            get
            {
                return StrengthMod + (_profAthletics ? _proficiency : 0);
            }
        }

        private bool _profDeception;
        public bool ProfDeception
        {
            get { return _profDeception; }
            set { _profDeception = value;
                OnPropertyChanged(nameof(Deception));
            }
        }
        public int Deception
        {
            get
            {
                return DexterityMod + (_profDeception ? _proficiency : 0);
            }
        }

        private bool _profHistory;
        public bool ProfHistory
        {
            get { return _profHistory; }
            set { _profHistory = value;
                OnPropertyChanged(nameof(History));
            }
        }
        public int History
        {
            get
            {
                return DexterityMod + (_profHistory ? _proficiency : 0);
            }
        }

        private bool _profInsight;
        public bool ProfInsight
        {
            get { return _profInsight; }
            set { _profInsight = value;
                OnPropertyChanged(nameof(Insight));
            }
        }
        public int Insight
        {
            get
            {
                return DexterityMod + (_profInsight ? _proficiency : 0);
            }
        }

        private bool _profIntimidation;
        public bool ProfIntimidation
        {
            get { return _profIntimidation; }
            set { _profIntimidation = value;
                OnPropertyChanged(nameof(Intimidation));
            }
        }
        public int Intimidation
        {
            get
            {
                return DexterityMod + (_profIntimidation ? _proficiency : 0);
            }
        }

        private bool _profInvestigation;
        public bool ProfInvestigation
        {
            get { return _profInvestigation; }
            set { _profInvestigation = value;
                OnPropertyChanged(nameof(Investigation));
            }
        }
        public int Investigation
        {
            get
            {
                return DexterityMod + (_profInvestigation ? _proficiency : 0);
            }
        }

        private bool _profMedicine;
        public bool ProfMedicine
        {
            get { return _profMedicine; }
            set { _profMedicine = value;
                OnPropertyChanged(nameof(Medicine));
            }
        }
        public int Medicine
        {
            get
            {
                return DexterityMod + (_profMedicine ? _proficiency : 0);
            }
        }

        private bool _profNature;
        public bool ProfNature
        {
            get { return _profNature; }
            set { _profNature = value;
                OnPropertyChanged(nameof(Nature));
            }
        }
        public int Nature
        {
            get
            {
                return DexterityMod + (_profNature ? _proficiency : 0);
            }
        }

        private bool _profPerception;
        public bool ProfPerception
        {
            get { return _profPerception; }
            set { _profPerception = value;
                OnPropertyChanged(nameof(Perception));
            }
        }
        public int Perception
        {
            get
            {
                return DexterityMod + (_profPerception ? _proficiency : 0);
            }
        }

        private bool _profPerformance;
        public bool ProfPerformance
        {
            get { return _profPerformance; }
            set { _profPerformance = value;
                OnPropertyChanged(nameof(Performance));
            }
        }
        public int Performance
        {
            get
            {
                return DexterityMod + (_profPerformance ? _proficiency : 0);
            }
        }

        private bool _profPersuasion;
        public bool ProfPersuasion
        {
            get { return _profPersuasion; }
            set { _profPersuasion = value;
                OnPropertyChanged(nameof(Persuasion));
            }
        }
        public int Persuasion
        {
            get
            {
                return DexterityMod + (_profPersuasion ? _proficiency : 0);
            }
        }

        private bool _profReligion;
        public bool ProfReligion
        {
            get { return _profReligion; }
            set { _profReligion = value;
                OnPropertyChanged(nameof(Religion));
            }
        }
        public int Religion
        {
            get
            {
                return DexterityMod + (_profReligion ? _proficiency : 0);
            }
        }

        private bool _profSleight_of_Hand;
        public bool ProfSleight_of_Hand
        {
            get { return _profSleight_of_Hand; }
            set { _profSleight_of_Hand = value;
                OnPropertyChanged(nameof(Sleight_of_Hand));
            }
        }
        public int Sleight_of_Hand
        {
            get
            {
                return DexterityMod + (_profSleight_of_Hand ? _proficiency : 0);
            }
        }

        private bool _profStealth;
        public bool ProfStealth
        {
            get { return _profStealth; }
            set { _profStealth = value;
                OnPropertyChanged(nameof(Stealth));
            }
        }
        public int Stealth
        {
            get
            {
                return DexterityMod + (_profStealth ? _proficiency : 0);
            }
        }

        private bool _profSurvival;
        public bool ProfSurvival
        {
            get { return _profSurvival; }
            set { _profSurvival = value;
                OnPropertyChanged(nameof(Survival));
            }
        }
        public int Survival
        {
            get
            {
                return DexterityMod + (_profSurvival ? _proficiency : 0);
            }
        }
    }
}
