using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet_Rework.ViewModels
{
    partial class CharacterViewModel : BaseViewModel
    {
        public void SaveToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                WriteValue(sw, nameof(Name), Name);
                WriteValue(sw, nameof(Race), Race);
                WriteValue(sw, nameof(Class), Class);
                WriteValue(sw, nameof(Background), Background);
                WriteValue(sw, nameof(Alignment), Alignment);
                WriteValue(sw, nameof(Playername), Playername);
                WriteValue(sw, nameof(ExperiencePoints), ExperiencePoints);
                WriteValue(sw, nameof(_proficiency), _proficiency);
                WriteValue(sw, nameof(HitDice), HitDice);
                WriteValue(sw, nameof(MaxHitPoints), MaxHitPoints);
                WriteValue(sw, nameof(CurrentHitPoints), CurrentHitPoints);
                WriteValue(sw, nameof(TemporaryHitPoints), TemporaryHitPoints);
                WriteValue(sw, nameof(Speed), Speed);
                WriteValue(sw, nameof(Initiative), Initiative);
                WriteValue(sw, nameof(ArmorClass), ArmorClass);
                WriteValue(sw, nameof(Inspiration), Inspiration);
                WriteValue(sw, nameof(DeathSaveFail0), DeathSaveFail0);
                WriteValue(sw, nameof(DeathSaveFail1), DeathSaveFail1);
                WriteValue(sw, nameof(DeathSaveFail2), DeathSaveFail2);
                WriteValue(sw, nameof(DeathSaveSuccess0), DeathSaveSuccess0);
                WriteValue(sw, nameof(DeathSaveSuccess1), DeathSaveSuccess1);
                WriteValue(sw, nameof(DeathSaveSuccess2), DeathSaveSuccess2);
                WriteValues(sw, nameof(ArmorProf), ArmorProf);
                WriteValues(sw, nameof(WeaponProf), WeaponProf);
                WriteValues(sw, nameof(ToolProf), ToolProf);
                WriteValues(sw, nameof(LanguageProf), LanguageProf);

                // Abilities
                WriteValue(sw, nameof(_strength), _strength);
                WriteValue(sw, nameof(ProfStrength), ProfStrength);
                WriteValue(sw, nameof(_dexterity), _dexterity);
                WriteValue(sw, nameof(ProfDexterity), ProfDexterity);
                WriteValue(sw, nameof(_constitution), _constitution);
                WriteValue(sw, nameof(ProfConstitution), ProfConstitution);
                WriteValue(sw, nameof(_intelligence), _intelligence);
                WriteValue(sw, nameof(ProfIntelligence), ProfIntelligence);
                WriteValue(sw, nameof(_wisdom), _wisdom);
                WriteValue(sw, nameof(ProfWisdom), ProfWisdom);
                WriteValue(sw, nameof(_charisma), _charisma);
                WriteValue(sw, nameof(ProfCharisma), ProfCharisma);


                WriteValue(sw, nameof(_profAcrobatics), _profAcrobatics);
                WriteValue(sw, nameof(_profAnimal_Handling), _profAnimal_Handling);
                WriteValue(sw, nameof(_profArcana), _profArcana);
                WriteValue(sw, nameof(_profAthletics), _profAthletics);
                WriteValue(sw, nameof(_profDeception), _profDeception);
                WriteValue(sw, nameof(_profHistory), _profHistory);
                WriteValue(sw, nameof(_profInsight), _profInsight);
                WriteValue(sw, nameof(_profIntimidation), _profIntimidation);
                WriteValue(sw, nameof(_profInvestigation), _profInvestigation);
                WriteValue(sw, nameof(_profMedicine), _profMedicine);
                WriteValue(sw, nameof(_profNature), _profNature);
                WriteValue(sw, nameof(_profPerception), _profPerception);
                WriteValue(sw, nameof(_profPerformance), _profPerformance);
                WriteValue(sw, nameof(_profPersuasion), _profPersuasion);
                WriteValue(sw, nameof(_profReligion), _profReligion);
                WriteValue(sw, nameof(_profSleight_of_Hand), _profSleight_of_Hand);
                WriteValue(sw, nameof(_profStealth), _profStealth);
                WriteValue(sw, nameof(_profSurvival), _profSurvival);
            }
        }

        private void WriteValue(StreamWriter streamWriter, string name, object value)
        {
            streamWriter.WriteLine($"{name}; {value};");
        }

        private void WriteValues(StreamWriter streamWriter, string name, ObservableCollection<string> values)
        {
            streamWriter.Write($"{name};");
            foreach (object value in values)
            {
                streamWriter.Write($"{value};");
            }
            streamWriter.WriteLine();
        }

        public static CharacterViewModel LoadFromFile(string path)
        {
            using (var streamReader = new StreamReader(path))
            {
                var NextValue = () =>
                {
                    return streamReader.ReadLine().Split(';')[1].TrimStart();
                };

                var NextValues = () =>
                {
                    var values = streamReader.ReadLine().Split(';').Skip(1).SkipLast(1);
                    ObservableCollection<string> strings = new();
                    foreach (var value in values)
                    {
                        strings.Add(value);
                    }
                    return strings;
                };

                var NextInt = () =>
                {
                    return int.Parse(NextValue());
                };

                var NextBool = () =>
                {
                    return bool.Parse(NextValue());
                };


                CharacterViewModel viewModel = new CharacterViewModel()
                {
                    Name = NextValue(),
                    Race = NextValue(),
                    Class = NextValue(),
                    Background = NextValue(),
                    Alignment = NextValue(),
                    Playername = NextValue(),
                    ExperiencePoints = NextInt(),
                    _proficiency = NextInt(),
                    HitDice = NextValue(),
                    MaxHitPoints = NextInt(),
                    CurrentHitPoints = NextInt(),
                    TemporaryHitPoints = NextInt(),
                    Speed = NextInt(),
                    Initiative = NextInt(),
                    ArmorClass = NextInt(),
                    Inspiration = NextBool(),
                    DeathSaveFail0 = NextBool(),
                    DeathSaveFail1 = NextBool(),
                    DeathSaveFail2 = NextBool(),
                    DeathSaveSuccess0 = NextBool(),
                    DeathSaveSuccess1 = NextBool(),
                    DeathSaveSuccess2 = NextBool(),
                    ArmorProf = NextValues(),
                    WeaponProf = NextValues(),
                    ToolProf = NextValues(),
                    LanguageProf = NextValues(),

                    // Abilities

                    _strength = NextInt(),
                    ProfStrength = NextBool(),
                    _dexterity = NextInt(),
                    ProfDexterity = NextBool(),
                    _constitution = NextInt(),
                    ProfConstitution = NextBool(),
                    _intelligence = NextInt(),
                    ProfIntelligence = NextBool(),
                    _wisdom = NextInt(),
                    ProfWisdom = NextBool(),
                    _charisma = NextInt(),
                    ProfCharisma = NextBool(),

                    _profAcrobatics = NextBool(),
                    _profAnimal_Handling = NextBool(),
                    _profArcana = NextBool(),
                    _profAthletics = NextBool(),
                    _profDeception = NextBool(),
                    _profHistory = NextBool(),
                    _profInsight = NextBool(),
                    _profIntimidation  = NextBool(),
                    _profInvestigation = NextBool(),
                    _profMedicine = NextBool(),
                    _profNature = NextBool(),
                    _profPerception = NextBool(),
                    _profPerformance = NextBool(),
                    _profPersuasion = NextBool(),
                    _profReligion = NextBool(),
                    _profSleight_of_Hand = NextBool(),
                    _profStealth = NextBool(),
                    _profSurvival = NextBool(),
                };


                return viewModel;
            }
        }
    }
}
