using UnityEngine;
using UnityEngine.SceneManagement;

public class BackController : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}