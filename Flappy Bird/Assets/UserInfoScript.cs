using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UserInfoScript : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public GameObject youLostScreen;

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void youLost()
    {
        youLostScreen.SetActive(true);
    }

    public void updateScore()
    {
        Score += 1;
        ScoreText.text = Score.ToString();
    }


}
