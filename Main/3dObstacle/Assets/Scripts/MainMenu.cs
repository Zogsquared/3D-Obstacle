using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void PlaySolo () {
        SceneManager.LoadScene("SinglePlayer");
    }

    public void QuitGame () {
        Debug.Log ("GAME QUIT");
        Application.Quit();
    }

    public void SplitScreen () {
        SceneManager.LoadScene("TwoPlayer");
    }

}
