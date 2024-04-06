using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningRoom :MonoBehaviour
{
    [SerializeField]
    private SceneController sceneController;

    public void ClickTheBowl()
    {
        Debug.Log("Play the cut finger animation and dialogue");
    }
}
