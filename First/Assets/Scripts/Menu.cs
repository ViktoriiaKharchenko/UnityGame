using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string profileName = "profile";
    public string mainMenuName = "menu2";
    public string firstLevel = "level_1";
    public SceneFader sceneFader;
    public void StartGame()
    {
        sceneFader.FadeTo(firstLevel);
    }
    public void ProfileLoad()
    {
        sceneFader.FadeTo(profileName);
    }
    public void MainMenuLoad()
    {
        sceneFader.FadeTo(mainMenuName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
