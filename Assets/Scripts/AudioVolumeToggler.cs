using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioVolumeToggler : MonoBehaviour
{
    private readonly float _minVolume = -80f;

    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private Toggle _toggle;

    private float _volumeStash;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleVolume);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveAllListeners();
    }

    public void ToggleVolume(bool isEnabled)
    {

        if (isEnabled)
        {
            _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, _volumeStash);
        }
        else
        {
            _mixerGroup.audioMixer.GetFloat(_mixerGroup.name, out _volumeStash);
            _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, _minVolume);
        }
    }
}