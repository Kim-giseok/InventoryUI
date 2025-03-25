using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [field: SerializeField] public ItemData data { get; private set; }
    public bool isEquip;

    public Item(ItemData data, bool isEquip = false)
    {
        this.data = data;
        this.isEquip = isEquip;
    }
}
