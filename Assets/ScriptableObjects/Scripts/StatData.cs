using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public enum StatType
{
    Atk,
    Def,
    Hp,
    Cri
}

[Serializable]
public class Stat
{
    public StatType type;
    public int value;
}

[CreateAssetMenu(fileName = "New StatData", menuName = "Data/Stat")]
public class StatData : ScriptableObject
{
    [field: SerializeField] public Stat[] Stats { get; private set; }
}
