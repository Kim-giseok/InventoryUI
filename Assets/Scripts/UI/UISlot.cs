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

    /// <summary>
    /// 슬롯에 아이템을 등록합니다.
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(Item item)
    {
        itemInfo = item;
        icon.sprite = item.data.icon;
    }

    /// <summary>
    /// 슬롯에 아이템 존재여부, 아이템의 장착여부를 표시해줍니다.
    /// </summary>
    public void RefreshUI()
    {
        icon.enabled = icon.sprite != null;
        equipTxt.enabled = itemInfo != null && itemInfo.isEquip;
    }

    /// <summary>
    /// 슬롯을 누르면 장착/해제합니다.
    /// </summary>
    public void OnClickToEquip()
    {
        if (itemInfo == null) return;

        UIManager.Instance.Inventory.EquipUnEquip(itemInfo);
        RefreshUI();
    }
}
