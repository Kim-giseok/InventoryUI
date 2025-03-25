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

    TextMeshProUGUI atkTxt;
    TextMeshProUGUI defTxt;
    TextMeshProUGUI hpTxt;
    TextMeshProUGUI criTxt;

    [Header("")]
    public Button backBtn;

    void Awake()
    {
        atkTxt = atk.Find("Stat").GetComponent<TextMeshProUGUI>();
        defTxt = def.Find("Stat").GetComponent<TextMeshProUGUI>();
        hpTxt = hp.Find("Stat").GetComponent<TextMeshProUGUI>();
        criTxt = cri.Find("Stat").GetComponent<TextMeshProUGUI>();
    }
}
