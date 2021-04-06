using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class driji : MonoBehaviour {

	public inigps gps;
	public List<Image> img;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < img.Count; i++) {
			if (gps.target - gps.hitungkembang  >= i) {
				img [i].transform.localPosition = Vector3.Lerp (img [i].transform.localPosition, new Vector3(img [i].transform.localPosition.x,0), Time.deltaTime * 3);

			} else {
				img [i].transform.localPosition = Vector3.Lerp (img [i].transform.localPosition, new Vector3(img [i].transform.localPosition.x,-1000), Time.deltaTime * 3);

			}
		}
	}
}
