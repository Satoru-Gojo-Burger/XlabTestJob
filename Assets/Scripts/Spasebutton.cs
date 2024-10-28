using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spasebutton : MonoBehaviour
{
    public GameObject item;
    public GameObject item2;
    public GameObject Activeitem;

    void Start()
    {
        item.SetActive(false);
        item2.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Activeitem.SetActive(false);
            item.SetActive(false);
            item2.SetActive(false);
            int eventIndex = UnityEngine.Random.Range(0,3);
            switch (eventIndex)
            {
                case 0:
                    item.SetActive(true);
                    break;
                case 1:
                    item2.SetActive(true);
                    break;
                case 2:
                    Activeitem.SetActive(true);
                    break;
            }
        }
    }
}
