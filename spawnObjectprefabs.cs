using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjectprefabs : MonoBehaviour {

    public GameObject cube;
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.A))
        {
            spawnPrefabs();
            Debug.Log("muncul");
        }
        else
        {
            Debug.Log("Gagal,tidak muncul");
        }
	}
    
    private void spawnPrefabs()
    {
        Instantiate(cube, transform.position, transform.rotation);
    }
}
