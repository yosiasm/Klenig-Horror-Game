using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomscream : MonoBehaviour {

	AudioSource gg;
	public List<AudioClip> clip;
	void Start () {
		gg = GetComponent<AudioSource> ();

	}
	
	float freq=0;
	void Update () {
		if (freq<Time.time) {
			freq = Time.time + 1;
			int a = (int)Random.Range (0, 35);
			//ebug.Log (a);
			if (a==10) {
				gg.clip = clip[Random.Range (0, clip.Count)];
				gg.Play ();	
			}

		}
	}
}
