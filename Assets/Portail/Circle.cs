﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {
    private float velocity =0.8f;
    void Update()
    {
        transform.Translate(velocity*0.05f *Vector3.right * Time.deltaTime);
        transform.Rotate(velocity*500 * Vector3.forward * Time.deltaTime);
    }
}
