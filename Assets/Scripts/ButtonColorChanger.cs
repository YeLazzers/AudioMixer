using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(UIButton))]
[RequireComponent(typeof(Image))]
public class ButtonColorChanger : MonoBehaviour
{
    private UIButton _button;
    private Image _image;

    private void Awake()
    {
        _button = GetComponent<UIButton>();
        _image = GetComponent<Image>();
    }

    private void OnEnable()
    {
        _button.Clicked += SetRandomColor;
    }

    private void OnDisable()
    {
        _button.Clicked -= SetRandomColor;
    }

    private void SetRandomColor()
    {
        _image.color = Random.ColorHSV();
    }
}