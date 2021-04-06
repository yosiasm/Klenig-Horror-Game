using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fading : MonoBehaviour {
	public Image gr;
	AudioSource au;

	void Start () {
		crit =((float)gameObject.GetComponent<Atan>().getdistance()) > 0.5f ? ((float)gameObject.GetComponent<Atan>().getdistance())/10 : 0.5f;
		startTime = Time.time+1;
		dur = Time.time + crit;
		au = GetComponent<AudioSource> ();
		//StartCoroutine (denting ());

	}
	public float minimum = 0.0f;
	public float maximum = 1f;
    float crit;
	float dur=0;
	private float startTime;
	void Update () {
		//sprite.color = new Color(1f,1f,1f,Mathf.SmoothStep(minimum, maximum, t));
		crit =((float)gameObject.GetComponent<Atan>().getdistance()) > 0.5f ? ((float)gameObject.GetComponent<Atan>().getdistance())/10 : 0.5f;

		if (Time.time>dur) {
			dur = Time.time + 1;
			au.Play ();
		}
		gr.CrossFadeAlpha (startTime-Time.time, 0, true);

	}

}
