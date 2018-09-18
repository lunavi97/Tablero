using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlEntrarHaz : MonoBehaviour {

    public AudioClip clip;
    float volumen = 1.0f;
    Transform posicion;

    void Start ()
    {
        posicion = transform;
    }

    void OnTriggerEnter (Collider other)
    {
        AudioSource.PlayClipAtPoint(clip, posicion.position, volumen);
        Destroy(this.gameObject);
    }
}
