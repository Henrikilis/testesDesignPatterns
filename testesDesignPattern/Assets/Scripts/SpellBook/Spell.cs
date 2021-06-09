using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
//using System.Diagnostics;

public abstract class Spell
{
    public abstract string Name { get; }
    public abstract void Process();

    public float cooldownTime;
    public bool timerActive;
}

public static class SpellFactory
{
    public static Dictionary<string, Type> spellsByName;
    private static bool IsInitialized => spellsByName != null;

    private static void InitializeFactory()
    {
        if (IsInitialized)
            return;

        var spellTypes = Assembly.GetAssembly(typeof(Spell)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Spell)));

        //Dicionario para encontrar isso por nome depois(pode ser enum/id ao inves de uma string)
        spellsByName = new Dictionary<string, Type>();

        // Pegar os nomes e colocar eles no dicionário
        foreach (var type in spellTypes)
        {
            var tempEffect = Activator.CreateInstance(type) as Spell;
            spellsByName.Add(tempEffect.Name, type);
        }
    }

    public static Spell GetSpell(string spellType)
    {
        InitializeFactory();

        if (spellsByName.ContainsKey(spellType))
        {
            Type type = spellsByName[spellType];
            var spell = Activator.CreateInstance(type) as Spell;
            return spell;
        }

        return null;
    }

    internal static IEnumerable<string> GetSpellNames2()
    {
        UnityEngine.Debug.Log("Test");
        InitializeFactory();
        return spellsByName.Keys;
    }
}
