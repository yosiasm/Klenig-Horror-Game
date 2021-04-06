using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkposisi : MonoBehaviour {
	public Transform target;
	private Transform temp;
	public float speed;
	bool move =true;
	void Start () {
		temp = target;
	}
	
	// Update is called once per frame
	void Update () {
		if (target.transform.position.y == transform.position.y) {
			move = true;
		}
		if (move) {
			transform.position = Vector3.MoveTowards(transform.position, temp.position,  speed);		
		}
		if (temp.transform.position.y == transform.position.y) {
			move = false;
		}

	}
}
