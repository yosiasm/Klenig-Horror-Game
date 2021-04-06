using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mini : MonoBehaviour {
	int posi=1;
	int jur;
	public float inv;
	void Start () {
		jur = GameObject.Find ("jalansusu").GetComponent<bintang> ().jur;
		transform.localScale = new Vector3(0.01f,0.01f,0.01f);

		//transform.localPosition = GameObject.Find ("bintang" + posi).transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = GameObject.Find ("jalansusu").GetComponent<Image> ().color;
		if (jur!=0) {
			
			if (posi >= jur) {
				posi = 1;
				transform.localPosition = GameObject.Find ("bintang" + posi).transform.localPosition;
			}
			transform.localPosition = Vector3.MoveTowards (
				transform.localPosition, GameObject.Find ("bintang" + (posi>jur?posi:posi+1)).transform.localPosition, (20+inv)*Time.deltaTime);

			if (transform.localPosition== GameObject.Find ("bintang" + (posi>jur?posi:posi+1)).transform.localPosition ) {
				posi++;


			}
		}

	}
}
