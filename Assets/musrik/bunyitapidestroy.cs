using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunyitapidestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!this.GetComponent<AudioSource> ().isPlaying)
			Destroy (this.transform.parent,2);
	}
}
