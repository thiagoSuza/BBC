using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HudInGameController : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenu;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TryAgain()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void NextMission(int x)
    {
        SceneManager.LoadScene(x);
    }

    public void OpenPauseMenu()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

   public void ExitApp()
   {
        Application.Quit();
   }

    public void SelectMissions()
    {
        SceneManager.LoadScene(1);
    }
}
