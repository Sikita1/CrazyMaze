using System.Collections;
using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _time;
    [SerializeField] private Text _timerText;

    public event UnityAction TimerEnd;

    private float _timeLeft = 0f;

    private void OnEnable()
    {
        _timeLeft = _time;
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.unscaledDeltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft <= 0)
        {
            _timeLeft = 0;
            TimerEnd?.Invoke();
        }

        _timerText.text = Math.Round(_timeLeft, 0).ToString();
    }
}
