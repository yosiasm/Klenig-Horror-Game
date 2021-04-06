using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hanacaraka : MonoBehaviour,IPointerClickHandler {
	public tutorialem tut;
	public void OnPointerClick(PointerEventData eventData){
		tut.ke = 0;
		PlayerPrefs.SetInt ("emper1", 0);
	}
}
