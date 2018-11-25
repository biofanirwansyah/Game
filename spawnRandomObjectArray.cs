using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRandomObjectArray : MonoBehaviour {

    public GameObject[] objek;
    public float minTime;
    public float maxTime;



    void Start()
    {
        InvokeRepeating("SpawnDevil", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));

    }


    void SpawnDevil()
    {
        Instantiate(objek[Random.Range(0, objek.Length)], transform.position, transform.rotation);
    }
}
