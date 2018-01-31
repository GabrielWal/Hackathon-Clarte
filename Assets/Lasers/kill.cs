using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("banana1");
		if (other.tag == "Zombie") {
			Debug.Log ("banana2");
			Destroy (other.gameObject);
		}
	}
}
