using UnityEngine;
using YG;

public class Advertisement : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    private void OnEnable()
    {
        YandexGame.OpenFullAdEvent += OpenCallback;
        YandexGame.CloseFullAdEvent += CloseCallback;
    }

    private void OnDisable()
    {
        YandexGame.OpenFullAdEvent -= OpenCallback;
        YandexGame.CloseFullAdEvent -= CloseCallback;
    }

    private void OpenCallback()
    {
        _audio.Pause();
        Time.timeScale = 0f;
    }

    private void CloseCallback()
    {
        Time.timeScale = 1f;
        _audio.UnPause();
    }
}
