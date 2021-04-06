using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ikitombolweapon : MonoBehaviour, IPointerClickHandler  {

	public Image senj;
	public koperasiweapon index;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void OnPointerClick(PointerEventData eventData){

		if (index.index<=PlayerPrefs.GetInt("stokweapon")) {
			PlayerPrefs.SetInt ("kodesenjata", index.index);
		}

		//Debug.Log ("lkdglsfkg");
	}
}
