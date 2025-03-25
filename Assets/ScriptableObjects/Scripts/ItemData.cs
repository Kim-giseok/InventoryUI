using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� �̸��� ���� �ɷ�ġ, �������� ����Ǵ� �������Դϴ�.
/// </summary>
[CreateAssetMenu(fileName = "New ItemData", menuName = "Data/Item")]
public class ItemData : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Stat[] Stats { get; private set; }

    public Sprite icon;
}
