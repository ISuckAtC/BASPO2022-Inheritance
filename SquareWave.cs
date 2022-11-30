using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareWave : SinWave
{
    protected override float GetY(float x)
    {
        float sin = base.GetY(x);
        return Mathf.Sign(sin);
    }
}
