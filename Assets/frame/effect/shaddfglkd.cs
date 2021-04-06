using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shaddfglkd : MonoBehaviour {

	public Transform target;
	public float skala;
	Vector3 awal;
	void Start () {
		awal = transform.localScale;
	}
	

	void Update () {
		float a = target.localPosition.y;
		transform.localScale = new Vector3 (awal.x - (a * skala), awal.y - (a * skala)+0.001f);
	}
}
