using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibleinvisible : MonoBehaviour {
    public GameObject cube; //variable untuk indikator objek yang diingikan
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//menekan keyboard huruf A sebagai indikator untuk objek muncul
        {
            cube.SetActive(true);//mengaktifkan objek
            Debug.Log("Aktif");
        }else if (Input.GetKeyDown(KeyCode.S))//menekan keyboard huruf S sebagai indikator untuk objek hilang
        {
            cube.SetActive(false);//menghilangkan objek 
            Debug.Log("Tidak Aktif");
        }
        else
        {
            Debug.Log("NO ACTION");
        }
    }
}
