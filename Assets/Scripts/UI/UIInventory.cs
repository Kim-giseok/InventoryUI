using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("InvenInfo")]
    public TextMeshProUGUI itemCntTxt;
    public TextMeshProUGUI maxItemCntTxt;

    [Header("UISlot")]
    public UISlot uiSlot;
    List<UISlot> uiSlots = new List<UISlot>();
    public Transform slotParant;

    [Header("")]
    public Button backBtn;
    public Character player;

    void Start()
    {
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);

        InitInventoryUI();
    }

    /// <summary>
    /// ó���� �÷��̾��� �κ��丮�� �ݿ����ݴϴ�.
    /// </summary>
    void InitInventoryUI()
    {
        int maxItmeCnt = Mathf.Max(12, player.Inventory.Count);
        for (int i = 0; i < maxItmeCnt; i++)
        {
            uiSlots.Add(Instantiate(uiSlot, slotParant));
            if (i < player.Inventory.Count)
                uiSlots[i].SetItem(player.Inventory[i]);
            uiSlots[i].RefreshUI();
        }

        maxItemCntTxt.text = $"/{maxItmeCnt}";
    }

    /// <summary>
    /// �÷��̾��� �κ��丮�� �������� �߰��� �� ȣ��Ǿ ������ �÷��ݴϴ�.
    /// </summary>
    /// <param name="item"></param>
    public void AddItem(Item item)
    {
        UISlot newSlot;
        if (uiSlots.Count < player.Inventory.Count)
        {
            newSlot = Instantiate(uiSlot, slotParant).GetComponent<UISlot>();
            uiSlots.Add(newSlot);
        }
        else
            newSlot = uiSlots[player.Inventory.Count - 1];

        newSlot.SetItem(item);
        newSlot.RefreshUI();
    }

    /// <summary>
    /// ������ ������ �������� �ش� �������� �����Ǿ��ִ��� ���ο� ���� ������ �ż��带 ȣ���մϴ�.
    /// </summary>
    /// <param name="item"></param>
    public void EquipUnEquip(Item item)
    {
        if (item.isEquip)
            player.UnEquip(item);
        else
            player.Equip(item);
    }
}
