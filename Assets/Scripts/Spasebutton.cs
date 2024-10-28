using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spasebutton : MonoBehaviour
{
    [SerializeField] private GameObject[] tools;

    void Start()
    {
        Change();
    }

    public void Change()
    {
        int Index = Random.Range(0,tools.Length);
            for (int i = 0; i < tools.Length; ++i)
            {
                tools[i].SetActive(i == Index);
            }
    }
}
