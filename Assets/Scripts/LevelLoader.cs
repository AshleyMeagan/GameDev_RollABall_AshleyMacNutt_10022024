using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // This field needs to be public or serialized to appear in the Inspector
    public string nextLevelName;  // Set this to the name of the next level in the Inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached the goal!");
            LoadNextLevel();
        }
    }

    void LoadNextLevel()
    {
        if (!string.IsNullOrEmpty(nextLevelName))
        {
            Debug.Log("Loading next scene: " + nextLevelName);
            SceneManager.LoadScene(nextLevelName);  // Load the scene by name
        }
        else
        {
            Debug.LogError("Next level name is not set!");
        }
    }
}
