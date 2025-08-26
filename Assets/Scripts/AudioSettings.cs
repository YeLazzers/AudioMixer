using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    private readonly string _masterParamName = "MasterVolume";
    private readonly string _musicParamName = "MusicVolume";
    private readonly string _effectsParamName = "EffectsVolume";
    private readonly float _minValue = -80f;
    private readonly float _maxValue = 0f;

    [SerializeField] private AudioMixer _masterMixer;

    private float _masterVolumeCash;

    public void ToggleMusic(bool isEnabled)
    {
        if (isEnabled)
        {
            ChangeVolume(_masterParamName, _masterVolumeCash);
        }
        else
        {
            _masterMixer.GetFloat(_masterParamName, out _masterVolumeCash);
            ChangeVolume(_masterParamName, _minValue);
        }
    }

    public void ChangeMasterVolume(float volume) =>
        ChangeVolumeLog(_masterParamName, volume);

    public void ChangeMusicVolume(float volume) =>
        ChangeVolumeLog(_musicParamName, volume);

    public void ChangeEffectsVolume(float volume) =>
        ChangeVolumeLog(_effectsParamName, volume);

    private void ChangeVolumeLog(string mixerGroupName, float volume)
    {
        _masterMixer.SetFloat(mixerGroupName, Mathf.Log10(volume) * 20);
    }

    private void ChangeVolume(string mixerGroupName, float volume)
    {
        _masterMixer.SetFloat(mixerGroupName, volume);
    }
}
