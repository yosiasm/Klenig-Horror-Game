using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gpstext : MonoBehaviour {
	public Text coordinate;
	public inigps gps;


	// Use this for initialization
	void Start () {
		
	}
	void Update () {
		coordinate.text = PlayerPrefs.GetFloat ("lat") + " <lat> "+gps.objLatitude+" lklk "+ 
			PlayerPrefs.GetFloat ("long") +" <long> "+ gps.objLongitude+" jarak:"+
			GameObject.Find("ball (1)").GetComponent<Atan>().getdistance().ToString() + " bear: " + 
			GameObject.Find("ball (1)").GetComponent<Atan>().bear.ToString();



		

	}
}
