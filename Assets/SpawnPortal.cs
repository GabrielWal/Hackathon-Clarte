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

    public float maxDistance = 0.25f;

    private float Normale(Vector3 x, Vector3 y)
    {
        return x.x * y.x + x.y * y.y + x.z * y.z;
    }
	// Update is called once per frame
	void Update () {
        if (true) // press bouton
        {
            pos0 = Vector3.zero; // Get pos of right controller
            pos1 = pos0 - new Vector3(0.7f, 1.0f, 0.0f); 
            pos2 = pos0 + new Vector3(0.7f, -1.0f, 0.0f);
        }
        if (true) // release bouton
        {
            if (Normale(pos0, posFinal) < maxDistance) // Si la position finale est proche de point de départ
            {
                drawing.z = 1;
            }
        }
        if (true) // calcul de la norme de la différence entre point en cours et un des points de passage
        {
            if (Normale(pos1, Vector3.zero) < maxDistance)
            {
                drawing.x = 1;
            }
            if (Normale(pos2, Vector3.zero) < maxDistance)
            {
                drawing.y = 1;
            }
        }
        if (drawing.x > 0.5 && drawing.y > 0.5 && drawing.z > 0.5)
        {
            Instantiate(portalToDrop, new Vector3(1.0f,1.0f,1.0f), Quaternion.identity);
        }
	}
}
