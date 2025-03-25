using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance => instance;

    [SerializeField] UIMainMenu mainMenu;
    [SerializeField] UIStatus status;
    [SerializeField] UIInventory inventory;

    public UIMainMenu MainMenu => mainMenu;
    public UIStatus Status => status;
    public UIInventory Inventory => inventory;
}
