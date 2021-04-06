using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class weaponnaik : MonoBehaviour, IPointerClickHandler  {

	public bool boleh;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (boleh) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector2 (0, 0), 2 * Time.deltaTime);

		}else {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector2 (0, -593.5f), 2 * Time.deltaTime);

		}

	}
	public void OnPointerClick(PointerEventData eventData){
		boleh = false;
	}

}
