using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Character player;
    [SerializeField] StatData characterStat;
    [SerializeField] ItemData[] itemDatas;

    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        List<Item> inventoy = new();
        foreach (var itemData in itemDatas)
            inventoy.Add(new Item(itemData));

        player = new Character("chad", 10, 9, 12, characterStat.Stats, 20000, inventoy);

        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}
