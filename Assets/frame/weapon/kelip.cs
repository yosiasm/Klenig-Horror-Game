using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kelip : MonoBehaviour {
	Vector3 startSc;
	float height=0.05f;
	float ran;

	void Start () {
		startSc = this.transform.localScale;
		ran = Random.Range (1,3);
	}

	void Update () {
		float mod = (0.5f + Mathf.Sin (Time.time*ran) * 0.5f) ;
		transform.localScale = startSc + Vector3.up * mod * height + Vector3.right * mod * height;

		//Debug.Log (PlayerPrefs.GetString("df"));
	}

}
