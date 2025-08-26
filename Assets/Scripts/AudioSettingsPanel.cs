using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsPanel : MonoBehaviour
{
    [SerializeField] private UISlider _masterSlider;
    [SerializeField] private UISlider _effectsSlider;
    [SerializeField] private UISlider _musicSlider;
    [SerializeField] private Toggle _volumeToggle;
    [SerializeField] private AudioSettings _settings;

    private void OnEnable()
    {
        _masterSlider.Slider.onValueChanged.AddListener(_settings.ChangeMasterVolume);
        _effectsSlider.Slider.onValueChanged.AddListener(_settings.ChangeEffectsVolume);
        _musicSlider.Slider.onValueChanged.AddListener(_settings.ChangeMusicVolume);

        _volumeToggle.onValueChanged.AddListener(_settings.ToggleMusic);
    }

    private void OnDisable()
    {
        _masterSlider.Slider.onValueChanged.RemoveAllListeners();
        _effectsSlider.Slider.onValueChanged.RemoveAllListeners();
        _musicSlider.Slider.onValueChanged.RemoveAllListeners();

        _volumeToggle.onValueChanged.RemoveAllListeners();
    }
}
