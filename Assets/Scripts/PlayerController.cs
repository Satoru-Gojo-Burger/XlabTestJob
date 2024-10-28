using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FreeCamera freeCamera;
    public GameObject ui;
    void Update()
    {
        if (!ui.activeSelf && freeCamera != null)
        {
            freeCamera.Move();
        }
    }
}
