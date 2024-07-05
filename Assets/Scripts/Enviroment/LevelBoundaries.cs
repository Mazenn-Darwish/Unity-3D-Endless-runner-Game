using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundaries : MonoBehaviour
{
    public static float leftSide=-3.5f;
    public static float rightSide=3.5f;
    public float internalleft;
    public float internalright;

   
    void Update()
    {
        internalleft = leftSide;
        internalright = rightSide;
    }
}
