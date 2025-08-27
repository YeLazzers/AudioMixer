using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _label;

    public Slider Slider => _slider;
    public TextMeshProUGUI Label => _label;
}
