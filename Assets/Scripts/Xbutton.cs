using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xbutton : MonoBehaviour
{
    public GameObject stonePrefab;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 pointPosition = transform.position;
            Instantiate(stonePrefab, pointPosition, Quaternion.identity);
        }
    }
}
