using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Xbutton stoneSpavn;
    private float m_timer;
    [SerializeField] 
    private float m_delay = 2f;
    public void OnEnable()
    {
        m_timer = Time.time - m_delay;
    }

    void Update()
    {
        if (Time.time > m_timer + m_delay)
        {
            stoneSpavn.Spawn();
            m_timer = Time.time;
        }
    }
}
