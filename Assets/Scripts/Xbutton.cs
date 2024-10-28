using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xbutton : MonoBehaviour
{
    public Transform point;
    public GameObject stonePrefab;

    private void Start()
    {
        if (point == null)
            point = transform;
    }

    public void Spawn()
    {
        Instantiate(stonePrefab, point.position, point.rotation);
    }
}
