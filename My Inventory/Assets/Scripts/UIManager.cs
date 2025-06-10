
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] TMP_Text atkText;
    [SerializeField] TMP_Text defText;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text criticalText;
    
    [Header("Inventory")]
    [SerializeField] Transform inventoryContent;
    [SerializeField] GameObject itemSlot;
    public void UpdateStatus(CharacterData characterData)
    {
        atkText.text = characterData.Attack.ToString();
        defText.text = characterData.Defense.ToString();
        hpText.text = characterData.HP.ToString();
        criticalText.text = characterData.Critical.ToString();
    }
    public void UpdateInventoryUI(CharacterData characterData)
    {
        foreach (Transform child in inventoryContent)
            Destroy(child.gameObject);

        foreach (var item in characterData.Inventory)
        {
            GameObject slotObj = Instantiate(itemSlot, inventoryContent);
            Inventory slot = slotObj.GetComponent<Inventory>();
            slot.SetItem(item);
        }
    }
    
}
