using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 아이템의 기본정보와 해당 아이템의 장착여부를 가지고 있습니다.
/// </summary>
[Serializable]
public class Item
{
    [field: SerializeField] public ItemData data { get; private set; }
    public bool isEquip;

    public Item(ItemData data, bool isEquip = false)
    {
        this.data = data;
        this.isEquip = isEquip;
    }
}
