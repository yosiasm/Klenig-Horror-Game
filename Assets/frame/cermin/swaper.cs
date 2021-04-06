using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class swaper : MonoBehaviour, IPointerClickHandler {

	public Sprite bunga;
	Sprite temp;
	public string namacard;
	public int index;
	void Start () {
		if (!(PlayerPrefs.GetInt ("stokkembang") >= index)) {
			swap ();

		} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void swap (){
		temp = GetComponent<Image>().sprite;
		GetComponent<Image>().sprite = bunga;
		bunga = temp;
	}
	public void OnPointerClick(PointerEventData eventData){
		if ( (PlayerPrefs.GetInt ("stokkembang") >= index) ) {
			//swap ();
			if (PlayerPrefs.GetString("chosenCard").Equals("")) {
				PlayerPrefs.SetString ("chosenCard", "plerok");
				PlayerPrefs.SetInt ("kodekembang", 0);
			}
			PlayerPrefs.SetString ("chosenCard", namacard);
			PlayerPrefs.SetInt ("kodekembang", index);
		}
	}
}
