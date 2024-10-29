using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xbutton : MonoBehaviour
{
    public Transform point;
    public GameObject[] stonePrefabs;

    private void Start()
    {
        if (point == null)
            point = transform;
    }

    public void Spawn()
    {
        int index = Random.Range(0, stonePrefabs.Length);
        Instantiate(stonePrefabs[index], point.position, point.rotation);
    }
}
