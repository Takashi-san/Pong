using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] GameManager _gameManager = null;
    [SerializeField] TextMeshProUGUI _victoryTx = null;

    private void OnEnable()
    {
        Time.timeScale = 0f;
        if (_gameManager._isP1Victory)
        {
            _victoryTx.text = "P1 Victory!!!";
        }
        else
        {
            _victoryTx.text = "P2 Victory!!!";
        }
    }
}
