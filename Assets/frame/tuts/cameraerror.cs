using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraerror : MonoBehaviour {
	WebCamTexture webCameraTexture;
	public GameObject webCameraPlane;
	void Start () {
		webCameraTexture = new WebCamTexture();
		webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
		webCameraTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
