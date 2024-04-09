using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocksMove : MonoBehaviour
{
    public LocksData data;

    public Color color;
    public int level;
    public string name;
    public string password;
    void Start()
    {
        gameObject.name = data.name;
        GetComponent<SpriteRenderer>().color = data.color;
        level = data.level;
        password = data.password;
    }

    void Update()
    {
        // check if something happens change the level data
    }
}
