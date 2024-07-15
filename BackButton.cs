using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public string sceneToLoad;

    public void GoBackToScene()
    {
        SceneManager.LoadScene("ui");
    }
}
