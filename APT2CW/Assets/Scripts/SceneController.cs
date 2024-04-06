using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SceneController : MonoBehaviour
{

    //public List<string> sceneNames = new List<string>();

    private void Awake()
    {

    }

    // Load next scene
    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
