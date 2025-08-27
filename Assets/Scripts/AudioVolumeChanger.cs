using UnityEngine;
using UnityEngine.Audio;

public class AudioVolumeChanger : MonoBehaviour
{
    private readonly float _minVolume = -80f;
    private readonly float _scaleCoefficient = 20f;

    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private UISlider _slider;

    private void OnEnable()
    {
        _slider.Slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.Slider.onValueChanged.RemoveAllListeners();
    }

    private void ChangeVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, volume == 0 ? _minVolume : Mathf.Log10(volume) * _scaleCoefficient);
    }
}