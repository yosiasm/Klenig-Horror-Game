using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeikut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().color = GameObject.Find ("jalansusu").GetComponent<Image> ().color;
		//Debug.Log (Screen.orientation);
	}
}
