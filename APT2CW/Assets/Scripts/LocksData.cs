using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Sprites/Locks/Locks Data")]
public class LocksData : ScriptableObject
{
    public string password;
    public int level;
    public string name;
    public Color color;
    public bool change;
}
