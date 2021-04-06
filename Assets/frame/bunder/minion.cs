using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minion : MonoBehaviour {

	public bool vertikal;
	public float spit;
	public int id;
	void Start () {
		if (vertikal) {
			transform.localPosition = Vector3.up * 350;
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = Vector3.Lerp (transform.localPosition, Vector3.down * 500, Time.deltaTime * spit*0.8f);
		if (transform.localPosition.y<-10) {
			transform.localScale = Vector3.zero;
		}
		if (this.name!="bucin") {
			if (transform.localPosition.y <45 && transform.localPosition.y > -45) {
				this.name = "prime";
			}
			if (transform.localPosition.y<-45) {
				this.name = "bekas prime";
			}
		}

	}
}
