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

    void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        invenBtn.onClick.AddListener(OpenInventory);
    }

    /// <summary>
    /// 메인매뉴가 보이게 합니다.
    /// </summary>
    public void OpenMainMenu()
    {
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);

        statusBtn.gameObject.SetActive(true);
        invenBtn.gameObject.SetActive(true);
    }

    /// <summary>
    /// 스테이터스 창이 보이게 합니다.
    /// </summary>
    public void OpenStatus()
    {
        statusBtn.gameObject.SetActive(false);
        invenBtn.gameObject.SetActive(false);

        UIManager.Instance.Status.gameObject.SetActive(true);
    }

    /// <summary>
    /// 인벤토리를 보이게 합니다.
    /// </summary>
    public void OpenInventory()
    {
        statusBtn.gameObject.SetActive(false);
        invenBtn.gameObject.SetActive(false);

        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }

    /// <summary>
    /// 항상 보여주는 정보들을 표시해줍니다.
    /// </summary>
    /// <param name="player"></param>
    public void SetInfo (Character player)
    {
        idTxt.text = player.Id;
        levelTxt.text = player.Level.ToString();
        exp.value = (float)player.Exp / player.MaxExp;
        expTxt.text = $"{player.Exp}/{player.MaxExp}";

        goldTxt.text = player.Gold.ToString();
    }
}
