using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TZ.Test1.Controller
{
public class PlayerController : MonoBehaviour
{
    [SerializeField] private FreeCamera freeCamera;
    [SerializeField] private GameObject ui;
    [SerializeField] private Xbutton xbutton;
    [SerializeField] private Zbutton zbutton;
    [SerializeField] private SpasebuttonController SpasebuttonController;
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
        if (SpasebuttonController != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpasebuttonController.Change();
            }
        }
    }
}
}
