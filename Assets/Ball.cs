using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball
{
    public float R;
    public Vector3 position;
    public Ball(float r, Vector3 pos)
    {
        R = r;
        position = pos;
    }

    public float Value(float x, float y, float z)
    {
        //TODO implement metaball function (Aufgabe 1)
        //useful functions: Mathf.Pow(), Mathf.Exp()

        return 0.0f;
    }
}
