using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zbutton : MonoBehaviour
{
    [SerializeField] private Transform m_point;
    [SerializeField] private List<Transform> m_mans;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private GameObject RainDropPrefab;
    int i = 0;
    private bool m_isMoving = false;
    private float lastSpawnTime = 0f;
    private const float spawnRate = 0.003f;

    public void MoveNext()
    {
        Debug.Log("Try Move");
        m_isMoving = true;
            i = i + 1;
            if (i == 8)
                i = 0;
    }

    void Update()
    {
        if (m_isMoving)
        {
            m_point.position = Vector3.MoveTowards(m_point.position, m_mans[i].position, speed * Time.deltaTime);
            if (m_mans[i].position == m_point.position)
            {
                m_isMoving = false;
            }
        }

        if (!m_isMoving)
        {
            if (Time.time - lastSpawnTime > spawnRate)
            {
                GameObject rainDrop = Instantiate(RainDropPrefab, m_point.position, Quaternion.identity);
                Destroy(rainDrop, 5f); 
                lastSpawnTime = Time.time;
            }
        }
    }
}