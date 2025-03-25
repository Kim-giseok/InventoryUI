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

    void Start()
    {
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);

        InitInventoryUI();
    }

    void InitInventoryUI()
    {
        for (int i=0;i < 12;i++)
        {
            uiSlots.Add(Instantiate(uiSlot, slotParant));
        }
    }
}
