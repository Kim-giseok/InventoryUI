using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 아이템의 이름과 제공 능력치, 아이콘이 저장되는 데이터입니다.
/// </summary>
[CreateAssetMenu(fileName = "New ItemData", menuName = "Data/Item")]
public class ItemData : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Stat[] Stats { get; private set; }

    public Sprite icon;
}
