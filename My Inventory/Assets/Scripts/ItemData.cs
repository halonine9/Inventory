using UnityEngine;

[CreateAssetMenu(menuName = "Item/EquipItem")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public int attackBonus;
    public int defenseBonus;
    public int hpBonus;
    public float criticalBonus;
}
