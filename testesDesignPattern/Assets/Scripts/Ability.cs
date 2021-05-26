using System;
using static UnityEngine.Debug;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace SimpleFactory
{
    public abstract class Ability
    {
        public abstract void Process();
    }

    public class StartFireAbility : Ability
    {
        public override void Process()
        {
            // Executar habilidade
            Debug.Log("SOLTANDO FOGO");
        }
    }
    public class HealSelfAbility : Ability
    {
        public override void Process()
        {
            // Executar habilidade
            Debug.Log("SE CURANDO");
        }
    }

    public class AbilityFactory
    {
        public static Ability GetAbility(string abilityType)
        {
            switch(abilityType)
            {
                case "fire":
                    return new StartFireAbility();
                case "heal":
                    return new HealSelfAbility();
                default:
                    return null;
            }
        }
    }
}