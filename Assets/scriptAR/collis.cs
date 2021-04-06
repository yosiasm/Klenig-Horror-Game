using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collis : MonoBehaviour {
	public Collider wolo;
	AudioSource audioo;
	void Start(){
		audioo = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col){
		inigps g = GameObject.Find ("wolo").GetComponent<inigps> ();
		g.hit = g.dalamArea;
		audioo.Play ();
		if ((int)Random.Range(1,40) == 4 && PlayerPrefs.GetInt ("umbul")<16) {
			PlayerPrefs.SetInt("umbul", PlayerPrefs.GetInt ("umbul")+1);

		}if ((int)Random.Range(1,90) == 4 && PlayerPrefs.GetInt ("story")<9) {
			PlayerPrefs.SetInt("story", PlayerPrefs.GetInt ("story")+1);

		}
		Debug.Log ("tem");
	}
}
