using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    string id;
    int level;
    int exp;
    int maxExp;
    int atk;
    int def;
    int hp;
    int cri;

    public Character(string id, int level, int exp, int maxExp, int atk, int def, int hp, int cri)
    {
        this.id = id;
        this.level = level;
        this.exp = exp;
        this.maxExp = maxExp;
        this.atk = atk;
        this.def = def;
        this.hp = hp;
        this.cri = cri;
    }
}
