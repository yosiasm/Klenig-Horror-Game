using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class kembalipon : MonoBehaviour, IPointerClickHandler {
	public Transform klfk;
	void Update () {
		transform.localPosition = klfk.localPosition + Vector3.right * 70 + Vector3.down * 120;

	}
	public void OnPointerClick(PointerEventData eventData){
		GameObject.Find ("weapon").GetComponent<tompon> ().mulai = false;
		//GameObject.Find ("b" + PlayerPrefs.GetString ("chosenWeapon")).GetComponent<kelip> ().swap ();
		//Debug.Log (GameObject.Find ("card").GetComponent<tomcard> ().mulai);
	}
}
