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
    /// ���Կ� �������� ����մϴ�.
    /// </summary>
    /// <param name="item"></param>
    public void SetItem(Item item)
    {
        itemInfo = item;
        icon.sprite = item.data.icon;
    }

    /// <summary>
    /// ���Կ� ������ ���翩��, �������� �������θ� ǥ�����ݴϴ�.
    /// </summary>
    public void RefreshUI()
    {
        icon.enabled = icon.sprite != null;
        equipTxt.enabled = itemInfo != null && itemInfo.isEquip;
    }

    /// <summary>
    /// ������ ������ ����/�����մϴ�.
    /// </summary>
    public void OnClickToEquip()
    {
        if (itemInfo == null) return;

        UIManager.Instance.Inventory.EquipUnEquip(itemInfo);
        RefreshUI();
    }
}
