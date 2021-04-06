using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class raycasbul : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Image> ().raycastTarget = GameObject.Find ("jalansusu").GetComponent<Image> ().raycastTarget;
	}
}
