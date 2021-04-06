using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tomcard : MonoBehaviour, IPointerClickHandler {
	public Transform tukaran;
	public bool mulai=false;
	void Update () {
		if (mulai) {
			tukaran.transform.localPosition = 
				Vector3.Lerp (tukaran.transform.localPosition, new Vector2 (0, -185), 4 * Time.deltaTime);



		} else {
			tukaran.transform.localPosition = 
				Vector3.Lerp (tukaran.transform.localPosition, new Vector2 (-1200, -185), 4 * Time.deltaTime);
				

		}
	}
	public void OnPointerClick(PointerEventData eventData){
		mulai = mulai ? false : true;
		PlayerPrefs.SetString ("chosenCard", "");
	}
}
