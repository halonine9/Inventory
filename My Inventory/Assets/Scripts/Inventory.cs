
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Image icon;
    
    public void SetItem(ItemData itemData)
    {
        if (icon != null && itemData != null)
        {
            icon.sprite = itemData.icon;
            icon.enabled = itemData.icon != null;
        }
    }

}
