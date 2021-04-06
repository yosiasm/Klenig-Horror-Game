using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class futar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		z = cw ? -1 : 1;
	}
	float z;
	public float speed;
	public bool cw;
	// Update is called once per frame
	void Update () {
		z = cw ? -1 : 1;
		this.transform.Rotate (0, 0, z*speed*Time.deltaTime);
	}
}
