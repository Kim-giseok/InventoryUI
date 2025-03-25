using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Character player;
    [SerializeField] StatData characterStat;
    [SerializeField] ItemData[] itemDatas;

    void Awake()
    {
        SetData();
    }

    /// <summary>
    /// 실행시 기본적인 데이터를 설정해 줍니다.
    /// </summary>
    public void SetData()
    {
        List<Item> inventoy = new();
        foreach (var itemData in itemDatas)
            inventoy.Add(new Item(itemData));

        player = new Character("chad", 10, 9, 12, characterStat.Stats, 20000, inventoy);

        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);
        UIManager.Instance.Inventory.player = player;

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}
