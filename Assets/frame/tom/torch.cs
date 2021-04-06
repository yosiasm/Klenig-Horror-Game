using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour {
	public Transform lirik;
	bool gantian;
	void Start () {
		ran ();
	}
	
	float x;
	float y;
	void ran(){
		x = Random.Range (-26, 26);
		y = Random.Range (-1.2f, 3);
	}
	void Update () {
		if (lirik.localPosition.x-x>-0.0001f || lirik.localPosition.x-x<0.0001f ) {
			ran ();
		} 
		if ((int)Random.Range(0,15)==3) {
			lirik.localPosition = new Vector3(-26,y);
		}else if ((int)Random.Range(0,10)==4) {
			lirik.localPosition = new Vector3(26,y);
		}else
			lirik.localPosition = Vector3.Lerp (lirik.localPosition, new Vector3(x,y), Time.deltaTime*3);

	}
}
