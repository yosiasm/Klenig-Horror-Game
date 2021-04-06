using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorsingle : MonoBehaviour {

	public coloran co;
	public List<GameObject> go;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject item in go) {
			item.GetComponent<Image> ().color = Color.Lerp (
				item.GetComponent<Image> ().color,
				co.getcolor (
					item.GetComponent<koperasiweapon> ().index), Time.deltaTime);

		}

	}
}
