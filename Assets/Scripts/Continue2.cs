using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript2 : MonoBehaviour // Unique class name
{
    public void ContinueGame2() // Unique method name
    {
        SceneManager.LoadScene("MiniGame"); // Change to the correct scene
    }
}