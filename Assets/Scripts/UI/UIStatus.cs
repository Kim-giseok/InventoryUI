using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("StatusList")]
    public RectTransform atk;
    public RectTransform def;
    public RectTransform hp;
    public RectTransform cri;

    public TextMeshProUGUI atkTxt;
    TextMeshProUGUI defTxt;
    TextMeshProUGUI hpTxt;
    TextMeshProUGUI criTxt;

    [Header("")]
    public Button backBtn;
    Character player;

    void Awake()
    {
        atkTxt = atk.Find("Stat").GetComponent<TextMeshProUGUI>();
        defTxt = def.Find("Stat").GetComponent<TextMeshProUGUI>();
        hpTxt = hp.Find("Stat").GetComponent<TextMeshProUGUI>();
        criTxt = cri.Find("Stat").GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    void OnEnable()
    {
        UpdateStats();
    }

    public void SetInfo(Character player)
    {
        this.player = player;
        UpdateStats();
    }

    void UpdateStats()
    {
        if (player == null) return;
        atkTxt.text = player.Stats[StatType.Atk].ToString();
        defTxt.text = player.Stats[StatType.Def].ToString();
        hpTxt.text = player.Stats[StatType.Hp].ToString();
        criTxt.text = player.Stats[StatType.Cri].ToString();
    }
}
