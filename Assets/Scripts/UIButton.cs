using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIButton : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerClickHandler
{
    private readonly Vector2 _pressedButtonLabelOffset = new Vector2(0, 17f);

    [SerializeField] private TextMeshProUGUI _label;

    private Vector2 _originalLabelPos;

    public event Action Clicked;

    private void Awake()
    {
        _originalLabelPos = _label.rectTransform.anchoredPosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _label.rectTransform.anchoredPosition = _originalLabelPos - _pressedButtonLabelOffset;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _label.rectTransform.anchoredPosition = _originalLabelPos;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Clicked?.Invoke();
    }
}