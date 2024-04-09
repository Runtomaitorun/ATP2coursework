using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LocksMove locks;
    public LocksData[] levelData;

    public int level;


    void Start()
    {
        // If go above max just turn back to max
        if (level > levelData.Length)
        {
            level = levelData.Length;
        }
        // pass SO info into the locks
        LocksData[] data = LocksData[level - 1];
        
    }

}
