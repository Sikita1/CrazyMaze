using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;

    private float _moveInputX;
    private float _moveInputY;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _moveInputX = _joystick.Horizontal;
        _moveInputY = _joystick.Vertical;

        _rigidbody.velocity = new Vector2(_moveInputX, _moveInputY) * _speed;
    }
}
