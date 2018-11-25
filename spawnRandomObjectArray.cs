using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRandomObjectArray : MonoBehaviour {

    public GameObject[] objek; //variable untuk menjadi indikator array dari gameobject nanti
    public float minTime;//rentan waktu minimal dari muncul nya game objek
    public float maxTime;//rentan waktu maksimal dari muncul nya game objek



    void Start()
    {
        //pemanggilan fungsi spawnObjek secara berulang dan secara acak(spawn gameobject dan posisi+rotasi)
        InvokeRepeating("SpawnDevil", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));

    }


    void SpawnObjek()//fungsi untuk memunculkan gameobject yang dimasukkan kedalam Array
    {
        Instantiate(objek[Random.Range(0, objek.Length)], transform.position, transform.rotation);
    }
}
