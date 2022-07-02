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
        //_icon.transform.GetComponent<RectTransform>().sizeDelta = _slotSize * Inventory.CellSize;
        //_backGround.transform.GetComponent<RectTransform>().sizeDelta = _slotSize * Inventory.CellSize;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _lastMousePosition = eventData.position;
    }

    public void OnDrag(PointerEventData data)
    {
        //RectTransform rectTransform = GetComponent<RectTransform>();
        Vector2 delta = data.position - _lastMousePosition;
        Vector2 tempPos = _icon.GetComponent<RectTransform>().position + new Vector3(delta.x, delta.y, _icon.GetComponent<RectTransform>().position.z);
        _icon.GetComponent<RectTransform>().position = tempPos;
        _lastMousePosition = data.position;

        tempPos.x = Mathf.Round(tempPos.x / 64.0f) * 64.0f;
        tempPos.y = Mathf.Round(tempPos.y / 64.0f) * 64.0f;
        //rectTransform.anchoredPosition = tempPos * 64.0f;
        Debug.Log(tempPos);
        _backGround.GetComponent<RectTransform>().position = tempPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        //Debug.Log(rectTransform.position);
    }
}
