using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tompon : MonoBehaviour, IPointerClickHandler {
	public Transform wepon;
	public bool mulai=false;
	void Update () {
		if (mulai) {
			wepon.transform.localPosition = 
				Vector3.Lerp (wepon.transform.localPosition, new Vector2 (0, -185), 4 * Time.deltaTime);
			

		} else {
			
			wepon.transform.localPosition = 
				Vector3.Lerp (wepon.transform.localPosition, new Vector2 (0,-1700), 4 * Time.deltaTime);
			


		}

	}
	public void OnPointerClick(PointerEventData eventData){
		mulai = mulai ? false : true;
		PlayerPrefs.SetString ("chosenWeapon", "");
	}
}
