using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _force;

    private PlayerInput _playerInput;
    private Rigidbody _rigidbody;
    private bool _inAir;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _rigidbody = GetComponent<Rigidbody>();

        _playerInput.Player.Jump.performed += ctx => OnJump();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }


    private void OnJump()
    {
        if (_inAir == false)
        {
            _inAir = true;
            _rigidbody.velocity = Vector2.up * _force;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Floor floor))
            _inAir = false;
    }
}
