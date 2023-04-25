using UnityEngine.SceneManagement;
using UnityEngine;

// adds functionality to replay & quit buttons
public class Events : MonoBehaviour
{
    // if the Replay? button is clicked, reload the level
    public void ReplayGame()
    {
        SceneManager.LoadScene("Level");
    }

    // if the Quit button is clicked, quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit!");
    }
}
