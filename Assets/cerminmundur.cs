using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cerminmundur : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (y) {
			GameObject.Find ("cermin").transform.localPosition = Vector3.Lerp (GameObject.Find ("cermin").transform.localPosition, new Vector3 (0, -500, 0), 3f * Time.deltaTime);	
			if (GameObject.Find ("cermin").transform.localPosition.y <=-499) {
				y = false;
			}
		}

	}
	bool y=false;
	public void OnPointerClick(PointerEventData eventData)
	{
		y = true;

	}
}
