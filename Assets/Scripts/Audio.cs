using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    [SerializeField] private AudioClip _fon;
    [SerializeField] private AudioClip _scrimer;

    private void Start()
    {
        _audioSource.clip = _fon;
        _audioSource.Play();
    }

    public void ScrimerPlay()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_scrimer);
    }
}
