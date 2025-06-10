
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public CharacterData Player { get; private set; }
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

    public void SetData()
    {
        Player = new CharacterData(Atk, Def, Hp, Critical);

        uiManager.UpdateStatus(Player);
     
    }
}
