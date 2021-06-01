using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string menuLevelName="menu2";
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public float moveToNextDelay = 1f;
    public GameObject completeLevelUi;

    public void CompleteLevel()
    {

        Invoke("MoveToNextLevel", moveToNextDelay);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menuLevelName);
        }
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    
void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    
void MoveToNextLevel()
    {
        completeLevelUi.SetActive(true);
    }
}
