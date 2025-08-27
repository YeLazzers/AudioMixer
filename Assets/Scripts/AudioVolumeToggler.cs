using UnityEngine;
using UnityEngine.UI;

public class AudioVolumeToggler : MonoBehaviour
{
    [SerializeField] private AudioListener _listener;
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
        _listener.enabled = isEnabled;
    }
}