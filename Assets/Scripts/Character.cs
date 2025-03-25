using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Id{ get; private set; }
    public int Level { get; private set; }
    public int Exp { get; private set; }
    public int MaxExp { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Cri { get; private set; }

    public int Gold { get; private set; }

    public Character(string id, int level, int exp, int maxExp, int atk, int def, int hp, int cri, int gold)
    {
        Id = id;
        Level = level;
        Exp = exp;
        MaxExp = maxExp;
        Atk = atk;
        Def = def;
        Hp = hp;
        Cri = cri;
        Gold = gold;
    }
}
