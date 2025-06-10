
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text atkText;
    [SerializeField] TMP_Text defText;
    [SerializeField] TMP_Text hpText;
    [SerializeField] TMP_Text criticalText;

    public void UpdateStatus(CharacterData characterData)
    {
        atkText.text = characterData.Attack.ToString();
        defText.text = characterData.Defense.ToString();
        hpText.text = characterData.HP.ToString();
        criticalText.text = characterData.Critical.ToString();
    }

}
