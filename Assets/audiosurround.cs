using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosurround : MonoBehaviour {

	public Transform camskrip;
	public Transform lukat;
	public Transform d;
	public List<AudioSource> au;
	public Atan at;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float c = camskrip.localRotation.y;
		float l = lukat.localRotation.y;
		foreach (var item in au) {
			item.panStereo = (c-l)/0.6f;
		}
		if (at.mendekat) {
			au [0].volume = 0.21f;
		}else
			au [0].volume = 0;

		d.transform.localPosition = Vector3.right * (c - l) / 0.6f * 26;
	}
}
