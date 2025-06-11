
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private GameObject equipMark;
    
    private ItemData curItem;

    //인벤토리에 표기될 아이템 아이콘
    public void SetItem(ItemData itemData)
    {
        if (icon != null && itemData != null)
        {
            curItem = itemData;
            icon.sprite = itemData.icon;
            icon.enabled = itemData.icon != null;
        }
    }
    //클릭시 장착
    public void OnClickEquip()
    {
        GameManager.Instance.SetEquip(curItem);
        UpdateEquipMark();
    } 
    //장착시 장착마크 활성화
    public void UpdateEquipMark()
    {
        bool equipped = GameManager.Instance.Player.IsEquipped(curItem);
        equipMark.SetActive(equipped);
    }
}
