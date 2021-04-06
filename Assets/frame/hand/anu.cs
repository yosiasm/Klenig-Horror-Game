using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anu : MonoBehaviour {
	public bool aksi;
	public bool naik;
	public Transform contai;
	public Transform spear;
	public Transform bullet;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (naik) {
			contai.localPosition = Vector3.Lerp (contai.localPosition,Vector3.zero, Time.deltaTime * 3.5f);
		}else
			contai.localPosition = Vector3.Lerp (contai.localPosition,new Vector3(0, -1000), Time.deltaTime * 3);


		if (naik) {
			spear.localPosition = Vector3.Lerp (spear.localPosition, new Vector3(-120, -86), Time.deltaTime * 2);
		}else
			spear.localPosition = Vector3.Lerp (spear.localPosition, new Vector3(-120, 600), Time.deltaTime * 3);

		if (contai.localPosition.y>-3) {
			naik = false;
			bullet.rotation = Camera.main.transform.rotation;
			bullet.position = Camera.main.transform.position;
		}




		if (Mathf.Abs (Mathf.Abs (Camera.main.transform.position.z) - Mathf.Abs (bullet.transform.position.z)) > 100) {
			bullet.transform.Translate (Vector3.forward * 0 * Time.deltaTime);
		} else {
			bullet.transform.Translate(Vector3.forward * 300f * Time.deltaTime);
		}
	}
}
