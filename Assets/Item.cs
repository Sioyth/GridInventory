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


    private Vector2 _lastMousePosition;
    private void Awake()
    {
        _icon.transform.GetComponent<RectTransform>().sizeDelta = _slotSize * Inventory.CellSize;
        _backGround.transform.GetComponent<RectTransform>().sizeDelta = _slotSize * Inventory.CellSize;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _lastMousePosition = eventData.position;
    }

    public void OnDrag(PointerEventData data)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 delta =data.position - _lastMousePosition;
        rectTransform.position = rectTransform.position + new Vector3(delta.x, delta.y, rectTransform.position.z);
        _lastMousePosition = data.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
}
