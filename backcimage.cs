using UnityEngine;
using UnityEngine.SceneManagement;

public class backcimage : MonoBehaviour
{
    public string sceneToLoad;

    public void GoBackToScene()
    {
        SceneManager.LoadScene("cimage");
    }
}
