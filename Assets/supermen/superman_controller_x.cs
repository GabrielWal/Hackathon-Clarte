using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superman_controller_x : MonoBehaviour {
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
		if (!b && transform.position.z < endPos.x) {
			transform.position += new Vector3 (1.0f, 0, 0) * speed;
		}
		if (transform.position.x >= endPos.x) {
			b = true;
			transform.eulerAngles += new Vector3 (0,180.0f,0); // demi-tour
		}
		if (b && transform.position.x > beginPos.x) {
			transform.position -= new Vector3 (1.0f, 0, 0) * speed;
		}
		if (transform.position.x <= beginPos.x) {
			b = false;
			transform.eulerAngles -= new Vector3 (0,180.0f,0); // demi-tour
		}
	}
}
