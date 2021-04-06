using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class purnawirawan : MonoBehaviour {

	public Image tr;
	public float kiri;
	public float kanan;
	void Start () {
		tr.transform.localPosition = Vector3.right * kiri;
	}
	
	// Update is called once per frame
	void Update () {
		tr.CrossFadeAlpha(GameObject.Find ("jalansusu").GetComponent<Image> ().color.a,0.01f,false);
		tr.transform.localPosition = Vector3.MoveTowards (tr.transform.localPosition, Vector3.right * kanan, Time.deltaTime * 9);
		if (tr.transform.localPosition.x==kanan) {
			tr.transform.localPosition = Vector3.right * kiri;
		}
	}
}
