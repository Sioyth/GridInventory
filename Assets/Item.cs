using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("Info")]
    [SerializeField] private uint _id;
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Vector2 _slotSize;

    [Header("UI")]
    [SerializeField] private Image _icon;
    [SerializeField] private Image _backGround;

    private void Awake()
    {
        RectTransform transform = GetComponent<RectTransform>();
        transform.sizeDelta = _slotSize * Inventory.CellSize;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData data)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
}
