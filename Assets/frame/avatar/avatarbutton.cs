using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class avatarbutton : MonoBehaviour,IPointerClickHandler {

	public bool onPanel;
	public avatarmisc misc;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPointerClick(PointerEventData eventData){
		if (onPanel) {
			misc.naik = false;
		} else
			misc.naik = true;
	}
}
