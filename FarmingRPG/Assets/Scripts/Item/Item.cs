using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private int _ItemCode;

    private SpriteRenderer spriteRenderer;

    public int ItemCode { get { return _ItemCode; } set { _ItemCode = value; } }

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        if (ItemCode != 0)
        {
            Init(ItemCode);
        }  
    }

    public void Init(int itemCodeParam)
    {
        
    }
}
