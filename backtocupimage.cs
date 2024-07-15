using UnityEngine;
using UnityEngine.SceneManagement;

public class backtocupscene : MonoBehaviour
{
    public string sceneToLoad;

    public void GoBackToScene()
    {
        SceneManager.LoadScene("cupscene");
    }
}
