using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getarancinta : MonoBehaviour {
	public Transform lirik;
	bool gantian;
	void Start () {
		ran ();
	}
	public float rx;
	public float ry;
	float x;
	float y;
	void ran(){
		x = Random.Range (rx, ry);
		y = Random.Range (rx, ry);
	}
	void Update () {
		if (lirik.localPosition.x-x>-0.0001f || lirik.localPosition.x-x<0.0001f ) {
			ran ();
		} 

			lirik.localPosition = Vector3.Lerp (lirik.localPosition, new Vector3(x,y), Time.deltaTime*4);

	}
}
