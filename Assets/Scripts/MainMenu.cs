using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    public string PlayGameLevel;

	public void PlayGame()
    {
        //Application.LoadLevel(PlayGameLevel);
        SceneManager.LoadScene(PlayGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
