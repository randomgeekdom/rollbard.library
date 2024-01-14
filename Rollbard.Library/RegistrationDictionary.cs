using Rollbard.Library.Models;
using Rollbard.Library.Rollers;
using Rollbard.Library.Rollers.Interfaces;
using System;
using System.Collections.Generic;

namespace Rollbard.Library
{
    public static class RegistrationDictionary
    {
        public static Dictionary<Type, Type> Get()
        {
            var dictionary = new Dictionary<Type, Type>();

            dictionary.AddTypes<ICharacterRoller, CharacterRoller>();
            dictionary.AddTypes<IMunicipalityNameRoller, MunicipalityNameRoller>();
            dictionary.AddTypes<IFantasticalNameRoller, FantasticalNameRoller>();
            dictionary.AddTypes<IJobRoller, JobRoller>();
            dictionary.AddTypes<INameRoller, NameRoller>();
            dictionary.AddTypes<IPersonalityTraitRoller, PersonalityTraitRoller>();
            dictionary.AddTypes<ISkillRoller, SkillRoller>();

            dictionary.AddTypes<IMunicipalityRoller, MunicipalityRoller>();
            dictionary.AddTypes<IRealNameRoller, RealNameRoller>();

            dictionary.AddTypes<INounRoller, NounRoller>();
            dictionary.AddTypes<IAdjectiveRoller, AdjectiveRoller>();
            dictionary.AddTypes<IFactionRoller, FactionRoller>();
            dictionary.AddTypes<IMonsterRoller, MonsterRoller>();
            dictionary.AddTypes<IBiomeRoller, BiomeRoller>();
            dictionary.AddTypes<ISpeciesRoller, SpeciesRoller>();
            dictionary.AddTypes<IRegionNameRoller, RegionNameRoller>();

            return dictionary;
        }

        private static void AddTypes<T1, T2>(this Dictionary<Type, Type> dictionary)
            where T2 : T1
        {
            dictionary.Add(typeof(T1), typeof(T2));
        }
    }
}