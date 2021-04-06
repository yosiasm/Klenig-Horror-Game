using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samakanpresepsi : MonoBehaviour {

	public inigps gps;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(PlayerPrefs.GetFloat("lat") - gps.objLatitude,PlayerPrefs.GetFloat("long") - gps.objLongitude,0);
	}
}
