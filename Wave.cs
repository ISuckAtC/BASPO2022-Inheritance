using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    private List<Transform> segments;
    public int segmentCount;
    public float boost;
    public float waveScale;
    public float precision;
    protected int index;
    private Transform currentSegment;
    public void Awake()
    {
        segments = new List<Transform>();
        for (int i = 0; i < segmentCount; ++i)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.parent = transform;
            obj.transform.localScale = new Vector3(waveScale, waveScale, waveScale);
            obj.transform.localPosition = new Vector3(i * waveScale, 0, 0);
            segments.Add(obj.transform);
        }
        currentSegment = segments[0];
    }

    public void Update()
    {
        UpdateSegment();
    }

    protected virtual float GetY(float x)
    {
        return x * boost;
    }

    protected void UpdateSegment()
    {
        currentSegment.GetComponent<MeshRenderer>().material.color = Color.white;

        currentSegment = segments[index];
        currentSegment.GetComponent<MeshRenderer>().material.color = Color.red;

        Vector3 position = currentSegment.position;
        position.y = GetY(index / precision);
        currentSegment.position = position;
        if (++index == segmentCount) index = 0;
    }
}
