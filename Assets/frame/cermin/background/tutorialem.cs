using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class tutorialem : MonoBehaviour , IPointerClickHandler{

	public List<Sprite> sprit;
	public List<string> strong;
	public Image background;
	public Text text;
	public int ke = 0;
	void Start () {
		
	}
	public void OnPointerClick(PointerEventData eventData){
		if (ke<=sprit.Count-1) {
			background.sprite = sprit [ke];
			text.text = strong [ke];

		}
		ke++;

	}
	void Update () {
		
		if (ke > sprit.Count || PlayerPrefs.GetInt ("emper1") == 1) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, Vector3.up * 1500, Time.deltaTime * 3);
			PlayerPrefs.SetInt ("emper1", 1);
		} else {
			transform.localPosition = Vector3.Lerp (transform.localPosition, Vector3.zero, Time.deltaTime * 3);
			PlayerPrefs.SetInt ("emper1", 0);
		}

	}
}
