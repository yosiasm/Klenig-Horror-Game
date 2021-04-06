using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dada : MonoBehaviour {

	void Start () {
	}
	float z=1;
	public bool cw;
	bool lewat;
	void Update () {
		this.transform.Rotate (0, 0, z*7*Time.deltaTime);
		if (transform.rotation.z<0.95f && z==-1 && lewat) {
			z = 1;
			lewat = false;
		}else if (transform.rotation.z<0.95f && z==1 && lewat) {
			z = -1;
			lewat = false;
		}else if (transform.rotation.z<0.99f) {
			lewat = true;
		}
		Debug.Log (transform.rotation.z);
	}
}
