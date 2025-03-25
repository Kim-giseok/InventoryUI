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
    /// 처음에 플레이어의 인벤토리를 반영해줍니다.
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
    /// 플레이어의 인벤토리에 아이템이 추가될 때 호출되어서 슬롯을 늘려줍니다.
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
    /// 아이템 슬롯이 눌러지면 해당 아이템이 장착되어있는지 여부에 따라 적절한 매서드를 호출합니다.
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
