using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string sceneName;



    public void LoadNextScene(string sceneName)
    {
        Debug.Log(gameObject.name + "clicked");
        SceneController.instance.NextScene(sceneName);
    }


}
