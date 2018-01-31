using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPortal : MonoBehaviour {

    [SerializeField] Vector3 pos0 = Vector3.zero;
    [SerializeField] Vector3 pos1 = Vector3.zero;
    [SerializeField] Vector3 pos2 = Vector3.zero;
    [SerializeField] Vector3 posFinal = Vector3.zero;
    [SerializeField] Vector3 drawing = Vector3.zero;

    public GameObject portalToDrop;
	public GameObject CenterEyeAnchor;
	public GameObject player;
	public GameObject tp;
	private GameObject clone;
	private bool portalCreated;

    [SerializeField] float maxDistance = -1.0f;

	void Start() {
		portalCreated = false;
	}

    private float Normale(Vector3 x, Vector3 y)
    {
        return x.x * y.x + x.y * y.y + x.z * y.z;
    }
	// Update is called once per frame
	void Update () {
		if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5f && !portalCreated)
		{
			clone = Instantiate(portalToDrop, transform.position + CenterEyeAnchor.transform.forward*3.0f, CenterEyeAnchor.transform.rotation);
            posFinal = pos0 + new Vector3(10.0f, 0.0f, 0.0f);
            drawing = Vector3.zero;
			portalCreated = true;
        }
		if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5f && portalCreated)
		{
			portalCreated = false;
			Destroy (clone);
		}
	}
}
