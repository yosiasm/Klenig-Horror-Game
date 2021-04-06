using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class torchdifabel : MonoBehaviour, IPointerClickHandler {

	public Transform tr;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public float x;
	public float y;
	public void OnPointerClick(PointerEventData eventData){
		tr.transform.localPosition = new Vector3 (x, y);
		Debug.Log ("hh");
	}
}
