using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpasebuttonController : MonoBehaviour
{
    public Spasebutton[] villagers;
    public void Change()
    {
        foreach (var villager in villagers)
        {
            villager.Change();
        }
    }
}
