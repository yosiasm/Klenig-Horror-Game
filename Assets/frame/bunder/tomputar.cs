using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tomputar : MonoBehaviour {

	public Transform ikut;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = new Quaternion (0, 0, ikut.rotation.z , 0);
	}
}
