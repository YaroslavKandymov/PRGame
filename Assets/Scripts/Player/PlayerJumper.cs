using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _groundDistance;

    private PlayerInput _playerInput;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _rigidbody = GetComponent<Rigidbody>();

        _playerInput.Player.Jump.performed += ctx => TryJump();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void TryJump()
    {
        if (Physics.Raycast(transform.position, Vector3.down, _groundDistance))
        {
            _rigidbody.velocity = Vector2.up * _force;
        }
    }
}
