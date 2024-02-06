using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Akses lebih banyak fungsi pada Unity UI
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField] public int playerScore;
    [SerializeField] public Text scoreText;
    public GameObject gameOverScreen;

    //context menu buat testing di unity
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
