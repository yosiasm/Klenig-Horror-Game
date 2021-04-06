using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class koperasiweapon : MonoBehaviour {
	public Sprite spritweapon;
	public Sprite kembang;
	public int index;
	public string penyimpanan;
	public GameObject inactive;
	void Start () {
		//Debug.Log (PlayerPrefs.GetInt (penyimpanan));
		if (PlayerPrefs.GetInt (penyimpanan) >= index) {
			GetComponent<Image> ().sprite = spritweapon;
		} else {
			GetComponent<Image> ().sprite = kembang;
			inactive.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
