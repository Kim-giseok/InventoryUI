using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] public Image icon;
    [SerializeField] TextMeshProUGUI equipTxt;
    Item itemInfo = null;

    public void SetItem(Item item)
    {
        itemInfo = item;
        icon.sprite = item.data.icon;
    }

    public void RefreshUI()
    {
        icon.enabled = icon.sprite != null;
        equipTxt.enabled = itemInfo != null && itemInfo.isEquip;
    }

    public void OnClickToEquip()
    {
        if (itemInfo == null) return;

        UIManager.Instance.Inventory.EquipUnEquip(itemInfo);
        RefreshUI();
    }
}
