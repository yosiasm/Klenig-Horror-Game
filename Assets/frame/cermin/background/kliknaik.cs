using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class kliknaik : MonoBehaviour,IPointerClickHandler {

	public storibos st;
	public void OnPointerClick(PointerEventData eventData){
		st.naik = true;

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
