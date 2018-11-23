using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjectprefabs : MonoBehaviour {

    public GameObject cube; //variable untuk indikator object yang akan dimasukkan
	
   void Update () {
	if (Input.GetKeyDown(KeyCode.A))//menekan keyboard huruf A sebagai indikator untuk objek muncul
        {
            spawnPrefabs();//pemanggilan fungsi yang akan digunakan
            Debug.Log("muncul");
        }
        else
        {
            Debug.Log("Gagal,tidak muncul");
        }
	}
    
    private void spawnPrefabs()//fungsi untuk memunculkan objek
    {
        Instantiate(cube, transform.position, transform.rotation);//memunculkan objek dari posisi dan rotasi berdasarkan prefabs
    }
}
