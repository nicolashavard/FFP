using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;

    public GameObject pauseMenu;

    private bool pausedGame;

    public Button muteButton;
    public Sprite soundOn;
    public Sprite soundOff;

    private void Start()
    {
        pausedGame = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        FindObjectOfType<GameManager>().Reset();
    }

    public void QuiToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuLevel);
    }

    public void MuteGame()
    {
        if (pausedGame)
        {
            AudioListener.volume = 1;
            pausedGame = !pausedGame;
            muteButton.image.sprite = soundOn;
        }
        else
        {
            AudioListener.volume = 0;
            pausedGame = !pausedGame;
            muteButton.image.sprite = soundOff;
        }
    }
}
