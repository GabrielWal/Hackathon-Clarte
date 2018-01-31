using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticle : MonoBehaviour {

    //private ParticleSystem particleSystem = GameObject.GetComponent<ParticleSystem>;
    public ParticleSystem particleSystem2;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            if (particleSystem2.isEmitting)
            {
                particleSystem2.Stop();
            }
            else
            {
                particleSystem2.Play();
            }
        }
    }
}
