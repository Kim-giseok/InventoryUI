using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Id{ get; private set; }
    public int Level { get; private set; }
    public int Exp { get; private set; }
    public int MaxExp { get; private set; }

    public Dictionary<StatType, int> Stats { get; private set; } = new();

    public int Gold { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string id, int level, int exp, int maxExp, Stat[] stats, int gold, List<Item> inventory)
    {
        Id = id;
        Level = level;
        Exp = exp;
        MaxExp = maxExp;

        foreach (var stat in stats)
            Stats[stat.type] = stat.value;

        Gold = gold;

        Inventory = inventory;
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(Item item)
    {
        item.isEquip = true;
        foreach (var stat in item.data.Stats)
            Stats[stat.type] += stat.value;
    }

    public void UnEquip(Item item)
    {
        foreach (var stat in item.data.Stats)
            Stats[stat.type] -= stat.value;
        item.isEquip = false;
    }
}
