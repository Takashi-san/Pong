using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _ball = null;
    [SerializeField] GameObject _victoryScreen = null;
    [SerializeField] GameObject _pauseScreen = null;
    public bool _isP1Victory = true;

    private void Awake()
    {
        Instantiate(_ball);
        _ball.GetComponent<Ball>().toP1 = Random.Range(0, 1) == 1;
    }

    public void FinishMatch(bool isP1Victory)
    {
        _isP1Victory = isP1Victory;
        _victoryScreen.SetActive(true);
    }
}
