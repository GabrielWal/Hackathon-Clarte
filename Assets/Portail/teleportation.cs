﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour {
	public GameObject tp;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Portail") {
			player.transform.position = tp.transform.position;
			player.transform.position += transform.forward;
		}
	}
}
