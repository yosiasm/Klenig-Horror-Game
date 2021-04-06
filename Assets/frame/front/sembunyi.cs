using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sembunyi : MonoBehaviour {
	public Transform target;
	bool hide=true;
	float pos;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 3.5f;
		pos =  transform.position.y;
	}
	Vector3 turun (float y)
	{
		return new Vector3 (transform.position.x, y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (target.position.y==Screen.height) {
			if (hide) {
				hide = false;
			} else {
				hide = true;
			}
		}
		if (hide) {
			transform.position = Vector3.MoveTowards (transform.position, turun (pos), speed);	
		} else {
			transform.position = Vector3.MoveTowards (transform.position, turun (0), speed);	
		}
	}
}
