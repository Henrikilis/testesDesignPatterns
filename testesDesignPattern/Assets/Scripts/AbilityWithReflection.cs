using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
using System.Linq;

namespace ReflectionFactory
{
    public abstract class Ability
    {
        public abstract string Name { get; }

        public abstract void Process();
    }

    public class StartFireAbility : Ability
    {
        public override string Name => "fire";

        public override void Process()
        {
            // IMPLEMENTAR FOGO
        }
    }

    public class HealSelfAbility : Ability
    {
        public override string Name => "heal";

        public override void Process()
        {
            // IMPLEMENTAR CURA
        }
    }

    public class AbilityFactory
    {
        private Dictionary<string, Type> abilitiesByName;

        public AbilityFactory()
        {
            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            //Dicionario para encontrar isso por nome depois(pode ser enum/id ao inves de uma string)
            abilitiesByName = new Dictionary<string, Type>();

            // Pegar os nomes e colocar eles no dicionário
            foreach(var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                abilitiesByName.Add(tempEffect.Name, type);
            }
        }

        public Ability GetAbility(string abilityType)
        {
            if(abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }
            return null;
        }

        internal IEnumerable<string> GetAbilityNames()
        {
            return abilitiesByName.Keys;
        }
    }
}
