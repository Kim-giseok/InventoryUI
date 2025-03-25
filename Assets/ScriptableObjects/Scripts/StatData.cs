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

/// <summary>
/// 플레이어의 능력치입니다.
/// </summary>
[CreateAssetMenu(fileName = "New StatData", menuName = "Data/Stat")]
public class StatData : ScriptableObject
{
    [field: SerializeField] public Stat[] Stats { get; private set; }
}
