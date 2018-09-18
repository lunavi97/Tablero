﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTablero : MonoBehaviour {
    
    public float velocidad = 20;

	void Update () {
        ControlarTablero();
	}

    void ControlarTablero()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(velocidad * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-velocidad * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -velocidad * Time.deltaTime);
        }
    }
}
