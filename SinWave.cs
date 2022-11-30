using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinWave : Wave
{
    protected override float GetY(float x)
    {
        return Mathf.Sin(x * Mathf.PI * 2f) * boost;
    }
}
