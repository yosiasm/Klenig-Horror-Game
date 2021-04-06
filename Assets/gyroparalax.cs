using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroparalax : MonoBehaviour {

	public float size;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
			transform.localPosition = new Vector2 (Input.acceleration.x*size + transform.localPosition.x,
				Input.acceleration.y*size +size+ transform.localPosition.y);
		
	}
}
