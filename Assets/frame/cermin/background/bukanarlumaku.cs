using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bukanarlumaku : MonoBehaviour {

	public Text text;
	public inigps dalamarea;
	bool asas=true;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dalamarea.dalamArea && asas) {
			text.text = "tenangno pikirmu";
			asas = false;
			StartCoroutine (hokya ());
		}
	}
	IEnumerator hokya(){
		yield return new WaitForSeconds (2);
		text.text = "";
	}
}
