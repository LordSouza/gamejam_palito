using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class playerMotion : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float xSpeed;
    private float xDir;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        xDir =  value.Get<Vector2>().x;
    }

    void Moving()
    {
        _rb.linearVelocityX = xDir * xSpeed * Time.deltaTime;
        
    }

    void FixedUpdate()
    {
        Moving();
        
    }
}
