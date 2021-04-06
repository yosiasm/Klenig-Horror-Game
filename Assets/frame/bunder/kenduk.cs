using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kenduk : MonoBehaviour {

	void Start () {
		startPos = this.transform.localPosition;
	}
	Vector3 startPos;
	float height=7;
	bool atas;
	void Update () {
		float mod = 0.5f + Mathf.Sin (Time.time) * 0.5f;
		transform.localPosition = startPos+ Vector3.up * mod * height;

		//Debug.Log ( Mathf.Sin (Time.time));
	}
}
