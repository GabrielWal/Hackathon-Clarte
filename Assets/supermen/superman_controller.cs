using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superman_controller : MonoBehaviour {
	public Vector3 beginPos;
	public Vector3 endPos;
	public float speed;

	private bool b;

	// Use this for initialization
	void Start () {
		b = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!b && transform.position.z < endPos.z) {
			transform.position += new Vector3 (0, 0, 1.0f) * speed;
		}
		if (transform.position.z >= endPos.z) {
			b = true;
			transform.eulerAngles += new Vector3 (0,180.0f,0); // demi-tour
		}
		if (b && transform.position.z > beginPos.z) {
			transform.position -= new Vector3 (0, 0, 1.0f) * speed;
		}
		if (transform.position.z <= beginPos.z) {
			b = false;
			transform.eulerAngles -= new Vector3 (0,180.0f,0); // demi-tour
		}
	}
}
