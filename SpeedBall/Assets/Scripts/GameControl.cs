using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//This class is created to control the game.Score increment and UI controls are controlled in this class.
public class GameControl : MonoBehaviour
{
    public Text scoreTxt;
    public Text highScoreTxt;
    int score;
    public GameObject ball;
    public Text gameOverTxt;
    public GameObject restartButton;
    public GameObject mainMenuButton;
    public GameObject resumeButton;
    public GameObject pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=0.7f;
        restartButton.SetActive(false);
        mainMenuButton.SetActive(false);
        resumeButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //In order to print the score on the screen, we need to get the value of the ball in the z direction.
        scoreTxt.text = "Score : " + ball.transform.position.z.ToString("0");
        score = Convert.ToInt32(ball.transform.position.z);

        //If the current score is higher than the high score, that's the new high score.
        if (score > PlayerPrefs.GetInt("HighScore", 0)) {
            PlayerPrefs.SetInt("HighScore", score);
        }

        //If the ball goes lower than the -1 position on the y-axis, the game is over, the restart and main menu button appears on the screen.
        //Besides, high score and game over texts are written on the screen.
        if (ball.transform.position.y <= -1)
        {
            restartButton.SetActive(true);
            mainMenuButton.SetActive(true);
            pauseButton.SetActive(false);
            ball.SetActive(false);
            gameOverTxt.text = "Game Over";
            highScoreTxt.text = "High Score is : "+PlayerPrefs.GetInt("HighScore",0).ToString();
        }
    }

    //If the user presses the restart button, the button reloads the game scene using this function.
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }

    //If the user presses the main menu button, the button reloads the main menu scene using this function.
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //If the user presses the pause button, the button uses this function to bring the resume, restart main menu keys to the screen.
    public void Pause() 
    {
        restartButton.SetActive(true);
        mainMenuButton.SetActive(true);
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        Time.timeScale = 0f;
    }

    //If the user presses the resume button, the button uses this function to remove the keys from the screen and animate the game again.
    public void Resume()
    {
        restartButton.SetActive(false);
        mainMenuButton.SetActive(false);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        Time.timeScale = 0.7f;
    }


}
