using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb = null;
    [SerializeField] float _velocity = 0;
    [Range(0.0f, 10.0f)] [SerializeField] float _angleControl = 1;

    void Start()
    {
        _rb.velocity = Vector2.right * _velocity;
    }

    public void NewDirection(float position)
    {
        Vector2 newVelocity;

        newVelocity.x = -Mathf.Sign(_rb.velocity.x);
        newVelocity.y = ((transform.position.y - position) / _angleControl);
        newVelocity *= _velocity;

        _rb.velocity = newVelocity;
    }
}
