using UnityEngine;

public class ClipPlayer : MonoBehaviour
{
    [SerializeField] private UIButton _button;

    private AudioSource _audio;

    private void OnEnable()
    {
        _button.Clicked += OnClicked;
    }

    private void OnDisable()
    {
        _button.Clicked -= OnClicked;
    }

    private void OnValidate()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnClicked()
    {
        _audio.PlayOneShot(_audio.clip);
    }
}
