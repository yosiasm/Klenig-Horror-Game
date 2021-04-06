using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class putarcompas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!Input.gyro.enabled) {
			Input.gyro.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion cameraRotation = new Quaternion (0, 0, Input.gyro.attitude.z, -Input.gyro.attitude.w);
		this.transform.localRotation = cameraRotation;
	}

}
