using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public void DoChange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
