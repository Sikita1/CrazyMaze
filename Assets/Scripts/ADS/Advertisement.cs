using System.Collections;
using UnityEngine;
using YG;

public class Advertisement : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private AudioSource _audio;

    private Coroutine _coroutine;

    private void Awake()
    {
        HideTimerPanel();
    }

    private void Start()
    {
        float timeToADS = YandexGame.Instance.infoYG.fullscreenAdInterval - (int)YandexGame.timerShowAd;

        if (timeToADS <= 0)
            _coroutine = StartCoroutine(StartTimerADS());
    }

    private void OnEnable()
    {
        _timer.TimerEnd += Show;
        YandexGame.CloseFullAdEvent += CloseCallback;
    }

    private void OnDisable()
    {
        _timer.TimerEnd -= Show;
        YandexGame.CloseFullAdEvent -= CloseCallback;
    }

    private void CloseCallback() =>
        HideTimerPanel();

    private void Show() =>
        YandexGame.FullscreenShow();

    private IEnumerator StartTimerADS()
    {
        yield return new WaitForSeconds(1f);

        _timer.gameObject.SetActive(true);
        _audio.Pause();
        Time.timeScale = 0f;
    }

    private void HideTimerPanel()
    {
        _timer.gameObject.SetActive(false);

        Time.timeScale = 1f;
        _audio.UnPause();
    }
}
