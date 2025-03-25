using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Character player;
    [SerializeField] StatData characterStat;

    void Start()
    {
        SetData();
    }

    public void SetData()
    {
        player = new Character("chad", 10, 9, 12, characterStat.Stats, 20000);

        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);

        UIManager.Instance.MainMenu.OpenMainMenu();
    }
}
