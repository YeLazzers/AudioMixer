using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlider : MonoBehaviour
{
    public Slider Slider { get; private set; }
    public TextMeshProUGUI Label { get; private set; }

    private void OnValidate()
    {
        Slider = GetComponentInChildren<Slider>();
        Label = GetComponentInChildren<TextMeshProUGUI>();
    }
}
