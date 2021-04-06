using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuts : MonoBehaviour {

	public Transform target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = Vector3.Lerp (transform.localPosition, target.localPosition, Time.deltaTime * 1);
	}
}
