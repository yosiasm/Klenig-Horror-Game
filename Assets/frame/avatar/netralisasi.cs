using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class netralisasi : MonoBehaviour, IPointerClickHandler {
	public tompon pon;
	public tomcard card;
	public avatarmisc ava;

	public void OnPointerClick(PointerEventData eventData){
		pon.mulai = false;
		card.mulai = false;
		ava.naik = true;
	}
}
