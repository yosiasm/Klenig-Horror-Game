using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gantipacar : MonoBehaviour {

	public List<Sprite> fanta;
	public List<Sprite> kratu;
	public Image pegangan;
	public Image kratauo;
	public bool emper;
	void Start () {
		pegangan.sprite = fanta [PlayerPrefs.GetInt ("kodesenjata")];
		kratauo.sprite = kratu [PlayerPrefs.GetInt ("kodekembang")];
	}
	
	// Update is called once per frame
	void Update () {
		if (emper) {
			pegangan.sprite = fanta [PlayerPrefs.GetInt ("kodesenjata")];
			kratauo.sprite = kratu [PlayerPrefs.GetInt ("kodekembang")];
		}
	}
}
