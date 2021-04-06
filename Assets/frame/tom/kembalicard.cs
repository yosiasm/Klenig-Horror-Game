using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class kembalicard : MonoBehaviour, IPointerClickHandler {

	public Transform klk;
	void Update () {
		
		transform.localPosition = klk.localPosition + Vector3.left * 70 + Vector3.down * 50;
	}
	public void OnPointerClick(PointerEventData eventData){
		GameObject.Find ("card").GetComponent<tomcard> ().mulai = false;
		GameObject.Find (PlayerPrefs.GetString ("chosenCard")).GetComponent<swaper> ().swap ();
		Debug.Log (GameObject.Find ("card").GetComponent<tomcard> ().mulai);
	}
}
