using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zbutton : MonoBehaviour
{
    public GameObject RainDropPrefab;
    public GameObject P;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;

    private float lastSpawnTime = 0f;
    private const float spawnRate = 0.003f;
    private bool isMoving = false;
    public float speed = 5.0f;
    //private int counter = 0;
    int i = 0;
    Vector3 N;

    void Update()
    {
        List<GameObject> list = new List<GameObject> { P, P2, P3, P4, P5, P6, P7, P8 };

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, list[i].transform.position, speed * Time.deltaTime);
            if (list[i].transform.position == transform.position)
            {
                isMoving = false;
            }

        }

        if (!isMoving)
        {
            if (Time.time - lastSpawnTime > spawnRate)
            {
                GameObject rainDrop = Instantiate(RainDropPrefab, transform.position, Quaternion.identity);
                Destroy(rainDrop, 5f); 
                lastSpawnTime = Time.time;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            isMoving = true;
            i = i + 1;
            if (i == 8)
                i = 0;
        }    

        //Первый способ реализации
        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    counter++;
        //    switch (counter)
        //    {

            //        case 1:
            //            N = P2.transform.position;
            //            isMoving = true;
            //            break;
            //        case 2:
            //            N = P3.transform.position;
            //            isMoving = true;
            //            break;
            //        case 3:
            //            N = P4.transform.position;
            //            isMoving = true;
            //            break;
            //        case 4:
            //            N = P5.transform.position;
            //            isMoving = true;
            //            break;
            //        case 5:
            //            N = P6.transform.position;
            //            isMoving = true;
            //            break;
            //        case 6:
            //            N = P7.transform.position;
            //            isMoving = true;
            //            break;
            //        case 7:
            //            N = P8.transform.position;
            //            isMoving = true;
            //            break;
            //    default:
            //            counter = 0;
            //            N = P.transform.position;
            //            isMoving = true;
            //            break;
            //    }
    }
}