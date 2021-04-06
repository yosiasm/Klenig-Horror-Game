using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dipencetbunyi : MonoBehaviour, IPointerClickHandler {
   	AudioSource aa;
	void Start () {
		aa = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPointerClick(PointerEventData eventData){
		aa.Play ();
	}
}
