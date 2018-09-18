using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTablero : MonoBehaviour {
    
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Tecla Arriba pulsada");
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tecla Izquierda pulsada");
        }

        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Tecla Abajo pulsada");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Tecla Derecha pulsada");
        }
	}
}
