using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lerpingcolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = Color.Lerp (GetComponent<Image> ().color, Color.red, Time.deltaTime*0.2f);
	}
}
