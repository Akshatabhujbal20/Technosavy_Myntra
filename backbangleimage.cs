using UnityEngine;
using UnityEngine.SceneManagement;

public class backbanglescene : MonoBehaviour
{
    public string sceneToLoad;

    public void GoBackToScene()
    {
        SceneManager.LoadScene("banglesscene");
    }
}