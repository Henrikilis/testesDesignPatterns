using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;

namespace ReflectionFactoryStatic
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
            Debug.Log("SOLTEI FOGO");
        }
    }

    public class HealSelfAbility : Ability
    {
        public override string Name => "heal";

        public override void Process()
        {
            Debug.Log("SE CURANDO");
        }
    }
    public class FlyAbility : Ability
    {
        public override string Name => "Fly";

        public override void Process()
        {
            Debug.Log("VOANDO");
        }
    }
    public class RespirarAbility : Ability
    {
        public override string Name => "Respirar";

        public override void Process()
        {
            Debug.Log("VOANDO");
        }
    }

    public static class AbilityFactory
    {
        private static Dictionary<string, Type> abilitiesByName;
        private static bool IsInitialized => abilitiesByName != null;

        private static void InitializeFactory()
        {
            if (IsInitialized)
                return;

            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            //Dicionario para encontrar isso por nome depois(pode ser enum/id ao inves de uma string)
            abilitiesByName = new Dictionary<string, Type>();

            // Pegar os nomes e colocar eles no dicionário
            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                abilitiesByName.Add(tempEffect.Name, type);
            }
        }

        private static Ability GetAbility(string abilityType)
        {
            InitializeFactory();

            if(abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetAbilityNames2()
        {
            UnityEngine.Debug.Log("Test");
            InitializeFactory();
            return abilitiesByName.Keys;
        }
    }
}