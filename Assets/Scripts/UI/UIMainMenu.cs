using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Info")]
    public TextMeshProUGUI idTxt;
    public TextMeshProUGUI levelTxt;
    public Slider exp;
    public TextMeshProUGUI expTxt;

    [Header("Gold")]
    public TextMeshProUGUI goldTxt;

    [Header("Buttons")]
    public Button statusBtn;
    public Button invenBtn;
}
