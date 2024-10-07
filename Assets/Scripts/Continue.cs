using UnityEngine;
using UnityEngine.SceneManagement; 

public class ContinueScript : MonoBehaviour
{
    public void ContinueGame()
    {
        SceneManager.LoadScene("Story2");
    }
}