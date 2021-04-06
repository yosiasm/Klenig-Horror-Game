using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orgakhir : MonoBehaviour {

	public Image alpha;
	public Sprite omega;
	public GameObject kupeng;
	public bool mengakhiri;
	void Start () {
		if (PlayerPrefs.GetInt ("akhir") == 1) {
			alpha.sprite = omega;

		} else if (kupeng != null) {
			
			Destroy (kupeng);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
