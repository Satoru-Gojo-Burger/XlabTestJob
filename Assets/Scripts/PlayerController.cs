using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FreeCamera freeCamera;
    public GameObject ui;
    public Xbutton xbutton;
    public Zbutton zbutton;
    void Update()
    {
        if (ui.activeSelf)
        {
            return;
        }
        if (freeCamera != null)
        {
            freeCamera.Move();
        }
        if (xbutton != null)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                xbutton.Spawn();
            }
        }
        if (zbutton != null)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                zbutton.MoveNext();
            }
        }
    }
}
