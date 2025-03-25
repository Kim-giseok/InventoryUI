using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Character player;

    public void SetData()
    {
        player = new Character("chad", 10, 9, 12, 35, 40, 100, 25, 20000);

        UIManager.Instance.MainMenu.SetInfo(player);
        UIManager.Instance.Status.SetInfo(player);
    }
}
