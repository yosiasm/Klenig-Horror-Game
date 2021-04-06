using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class itembaru : MonoBehaviour, IPointerClickHandler {

	public Image a;
	public SpriteRenderer b;
	public Sprite A;
	public bool sceneEmper;
	public string penyimpanan;

	public void OnPointerClick(PointerEventData eventData){
		if (sceneEmper) {
			PlayerPrefs.SetInt (penyimpanan, 0);
		}
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!(PlayerPrefs.GetInt(penyimpanan)==1)) {
			a.sprite = A;
			if (!sceneEmper) {
				b.sprite = A;	
			}

		}
	}
}
