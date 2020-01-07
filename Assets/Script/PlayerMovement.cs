using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb = null;
    [SerializeField] float _velocity = 0;
    [SerializeField] float _mapLimit = 6;
    float _horizontal;

    private void Update()
    {
        _horizontal = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.velocity = Vector2.up * _velocity * _horizontal;
        if (Mathf.Sign(_rb.velocity.y) > 0)
        {
            if (transform.position.y > _mapLimit)
            {
                _rb.velocity = Vector2.zero;
            }
        }
        else
        {
            if (transform.position.y < -_mapLimit)
            {
                _rb.velocity = Vector2.zero;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball)
        {
            ball.NewDirection(transform.position.y);
        }
    }
}
