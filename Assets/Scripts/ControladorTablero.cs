using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTablero : MonoBehaviour {
    
    public float velocidad = 20;
    private float limiteRotacion = 0.15f;

	void Update () {
        ControlarTablero();
	}

    void ControlarTablero()
    {
        if (Input.GetKey(KeyCode.W) && transform.rotation.x < limiteRotacion)
        {
            transform.Rotate(velocidad * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A) && transform.rotation.z < limiteRotacion)
        {
            transform.Rotate(0, 0, velocidad * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.S) && transform.rotation.x > -limiteRotacion)
        {
            transform.Rotate(-velocidad * Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.D) && transform.rotation.z > -limiteRotacion)
        {
            transform.Rotate(0, 0, -velocidad * Time.deltaTime);
        }
    }
}
