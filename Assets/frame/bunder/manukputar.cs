using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class manukputar : MonoBehaviour, IPointerClickHandler {
	void Start(){
		Screen.orientation = ScreenOrientation.Portrait;
	}
	public void OnPointerClick(PointerEventData eventData){
		if (Screen.orientation==ScreenOrientation.Portrait ) {
			Screen.orientation = ScreenOrientation.Landscape; 
		}else
			Screen.orientation = ScreenOrientation.Portrait; 

	}
	// Update is called once per frame
	void Update () {
		
	}
}
