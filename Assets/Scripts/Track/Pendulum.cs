using DG.Tweening;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField] private Transform _positionEnd;
    [SerializeField] private float _duration;

    private void Start()
    {
        Pump();
    }

    private void Pump()
    {
        transform.DOMove(_positionEnd.position, _duration)
                 .SetLoops(-1, LoopType.Yoyo)
                 .SetEase(Ease.Linear);
    }
}
