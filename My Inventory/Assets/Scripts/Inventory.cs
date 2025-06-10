
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private GameObject equipMark;
    
    private ItemData curItem;

    
    public void SetItem(ItemData itemData)
    {
        if (icon != null && itemData != null)
        {
            curItem = itemData;
            icon.sprite = itemData.icon;
            icon.enabled = itemData.icon != null;
        }
    }
    public void OnClickEquip()
    {
        GameManager.Instance.SetEquip(curItem);
        UpdateEquipMark();
    } 
    public void UpdateEquipMark()
    {
        bool equipped = GameManager.Instance.Player.IsEquipped(curItem);
        equipMark.SetActive(equipped);
    }
}
