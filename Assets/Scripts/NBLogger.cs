using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBLogger : MonoBehaviour
{
    private void Awake()
    {
        Log("Awake");
    }
    private void OnAble()
    {
        Log("Awake");
    }
    private void Start()
    {
        Log("Awake");
    }
    private void FixedUpdate(){}

    
    private void Log(string msg)
    {
        Debug.Log($"{name}: msg - frame{Time.frameCount}");
    }
}
