using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mbatin : MonoBehaviour {
	public inigps gps;

	void Update () {
		transform.localPosition = new Vector3(PlayerPrefs.GetFloat("lat") - gps.objLatitude, PlayerPrefs.GetFloat("long") - gps.objLongitude, 0);	
	}
}
