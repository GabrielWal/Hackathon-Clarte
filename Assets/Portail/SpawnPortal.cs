using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour {

    public GameObject portalToDrop;
	public GameObject tp;
	private GameObject clone;
	private bool portalCreated;
    
	void Start() {
		portalCreated = false;
	}
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p") && !portalCreated)
		{
			clone = Instantiate(portalToDrop, transform.position + 3*transform.forward, transform.rotation);
			portalCreated = true;
        }
		if (Input.GetKeyDown("m") && portalCreated)
		{
			portalCreated = false;
			Destroy (clone);
		}
	}
}
