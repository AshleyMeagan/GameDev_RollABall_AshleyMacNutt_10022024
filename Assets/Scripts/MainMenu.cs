using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // This method will be called when the Play button is pressed
    public void PlayGame()
    {
        // Replace "GameScene" with the name of the scene where the game is located
        SceneManager.LoadScene("MiniGame");
    }

    // This method will be called when the Quit button is pressed
    public void QuitGame()
    {
        Debug.Log("Quit Game!");  // This will log in the editor (doesn't work in the editor but will work in a build)
        Application.Quit();       // This will quit the application in the final build
    }
}
