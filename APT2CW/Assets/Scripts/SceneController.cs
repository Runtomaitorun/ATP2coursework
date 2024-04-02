using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;

    public List<string> sceneNames = new List<string>();

    private void Awake()
    {
        // Ensure SceneController instance exist
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Load next scene
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
