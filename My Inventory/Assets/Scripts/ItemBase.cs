
using UnityEngine;

[System.Serializable]
public class ItemBase
{
    public ItemData Data { get; private set; }

    public string Name => Data.itemName;
    public Sprite Icon => Data.icon;
    public int AttackBonus => Data.attackBonus;
    public int DefenseBonus => Data.defenseBonus;
    public int HPBonus => Data.hpBonus;
    public float CriticalBonus => Data.criticalBonus;

    public ItemBase(ItemData data)
    {
        Data = data;
    }
}
