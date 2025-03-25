using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �̱������� �� ui�� �����ϰ� �� �ݴϴ�.
/// </summary>
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

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
}
