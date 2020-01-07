using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour
{
    public void MatchShadow()
    {
        SceneManager.LoadScene("Match-shadow");
    }

    public void Match2P()
    {
        SceneManager.LoadScene("Match-2p");
    }

    public void MatchBOT()
    {
        SceneManager.LoadScene("Match-BOT");
    }
}
