﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlEntrarHaz : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
