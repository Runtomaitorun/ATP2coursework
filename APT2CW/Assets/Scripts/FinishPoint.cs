using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string sceneName;


    public void OnMouseDown()
    {
        LoadNextScene(sceneName);
    }
    public void LoadNextScene(string sceneName)
    {
        SceneController.instance.NextScene(sceneName);
    }


}
