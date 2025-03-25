using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] public Image icon;
    [SerializeField] TextMeshProUGUI equipTxt;
    [SerializeField] Item Item;

    public void SetItem(Item item)
    {
        Item = item;
        icon.sprite = item.data.icon;
    }

    public void RefreshUI()
    {
        icon.enabled = icon.sprite != null;
        equipTxt.enabled = Item != null && Item.isEquip;
    }

    public void OnClickToEquip()
    {
        if (Item == null) return;

        UIManager.Instance.Inventory.EquipUnEquip(Item);
        RefreshUI();
    }
}
