using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
