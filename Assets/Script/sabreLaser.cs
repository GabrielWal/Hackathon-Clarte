using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VolumetricLines;

public class sabreLaser : MonoBehaviour {

	public GameObject mainsGauche;
	public GameObject mainsDroite;
	public GameObject sabre;//Sabre
	public float trigger;// = Input.GetAxis("Oculus_GearVR_LIndexTrigger");

	public VolumetricLineBehavior sabreBeha;

	float sabreScale = 0.0f;
	public float distmax = 10.0f;
	public float anglemax = 40.0f;
	public float coefmaindroite = 0.0f;
	// Use this for initialization
	void Start () {
		mainsGauche.transform.position = new Vector3(1,0,0);
		mainsDroite.transform.position = new Vector3(-1,0,0);
	}
	
	// Update is called once per frame
	void Update () {


		trigger = Input.GetAxis("Horizontal");
		Debug.Log (trigger);

		if(
			Vector3.Distance(mainsGauche.transform.position,mainsDroite.transform.position)<=distmax
			&&
			Vector3.Angle(mainsGauche.transform.up, mainsDroite.transform.up)<anglemax
			&&
			Vector3.Angle(mainsDroite.transform.position - mainsGauche.transform.position - mainsDroite.transform.forward*coefmaindroite, mainsDroite.transform.up)<30.0f
			//&&

		){
			if (sabreScale <= 50f){
					sabreScale += 2f;
			}

		}else{

			if (sabreScale >= 0f){
				sabreScale -= 2f;
			}

		}
		sabreBeha.EndPos = new Vector3(0, sabreScale, 0);

		if(sabreScale>=1f){
			GameObject go = GameObject.Instantiate(sabre, mainsDroite.transform.position + mainsDroite.transform.up * 0.2f, mainsDroite.transform.rotation) as GameObject;

			GameObject.Destroy(go,0.05f);
		}
	}
}
