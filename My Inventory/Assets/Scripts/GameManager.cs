
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ItemData[] ItemDatas;
    
    public static GameManager Instance;
    public CharacterData Player { get; private set; }
    public Inventory inventory { get; private set; }
    [SerializeField] private UIManager uiManager;
    
    [Header("능력치")]
    [SerializeField] private int Atk;
    [SerializeField] private int Def;
    [SerializeField] private int Hp;
    [SerializeField] private float Critical;
    

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetData();
    }
    //캐릭터 데이터 설정
    public void SetData()
    {
        Player = new CharacterData(Atk, Def, Hp, Critical);
        foreach (var item in ItemDatas)
        {
            if (item != null)
            {
                Player.Inventory.Add(item);
            }
        }
        //UI 연동
        uiManager.UpdateStatus(Player);
        uiManager.UpdateInventoryUI(Player);
    }
    //장착
    public void SetEquip(ItemData item)
    {
        Player.Equip(item);
        uiManager.UpdateStatus(Player);
    }

 
    
}
