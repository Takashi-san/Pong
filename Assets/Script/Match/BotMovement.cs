using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb = null;
    [SerializeField] float _velocity = 0;
    [SerializeField] float _mapLimit = 6;
    [SerializeField] float _speedControl = 1;
    [SerializeField] float _gapControl = 0.4f;
    [SerializeField] Scorer _playerScorer = null;
    [SerializeField] Scorer _myScorer = null;
    float _horizontal;

    private void Update()
    {
        Transform ball = FindObjectOfType<Ball>().transform;     // isso aqui é muito ruim.
        float distance = ball.position.y - transform.position.y;
        int gap = _playerScorer.GetScore() - _myScorer.GetScore();

        float difficulty = _speedControl + (_gapControl * gap);
        _horizontal = Mathf.Abs(distance * difficulty) > 1 ? Mathf.Sign(distance) : distance * difficulty;
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
