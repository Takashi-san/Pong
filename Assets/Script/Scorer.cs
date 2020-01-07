using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] int _initialScore = 0;
    [SerializeField] TextMeshProUGUI _scoreText = null;
    [SerializeField] GameObject _ball = null;
    [SerializeField] bool resetToP1 = false;
    int _score = 0;

    private void Start()
    {
        _scoreText.text = _initialScore.ToString();
        _score = _initialScore;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Ball ball = other.GetComponent<Ball>();
        if (ball)
        {
            Destroy(ball.gameObject);
            UpdateScore();
            ball = Instantiate(_ball).GetComponent<Ball>();
            ball.toP1 = resetToP1;
        }
    }

    private void UpdateScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}
