﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibleinvisible : MonoBehaviour {
    public GameObject cube;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cube.SetActive(true);
            Debug.Log("Aktif");
        }else if (Input.GetKeyDown(KeyCode.S))
        {
            cube.SetActive(false);
            Debug.Log("Tidak Aktif");
        }
        else
        {
            Debug.Log("NO ACTION");
        }
    }
}
