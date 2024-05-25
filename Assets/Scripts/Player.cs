using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void SetStartPosition() =>
        transform.position = _startPosition;
}
