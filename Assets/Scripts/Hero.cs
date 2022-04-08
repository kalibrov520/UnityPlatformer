using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hero : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    [SerializeField] public float jumpForce = 50;
    
    private Vector2 _direction;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (_direction.magnitude != 0)
        {
            Walk(_direction);
        }
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }
    
    private void Walk(Vector2 direction)
    {
        _rb.velocity = new Vector2(direction.x * speed, _rb.velocity.y);
    }

    public void Jump()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, 0);
        _rb.velocity += Vector2.up * jumpForce;
    }
}
