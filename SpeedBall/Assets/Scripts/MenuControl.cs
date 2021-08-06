using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This class is created to control the Main menu scene.
public class MenuControl : MonoBehaviour
{
    //If the user presses the play game button, the button reloads the game scene using this function.
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    //If the user presses the quit game button, the button quits the game using this function.
    public void QuitGame()
    {
        Application.Quit();
    }
}
