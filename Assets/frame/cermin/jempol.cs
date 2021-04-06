using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class jempol : MonoBehaviour , IPointerClickHandler{

	// Update is called once per frame
	void Update () {
		if (!PlayerPrefs.GetString("chosenCard").Equals("")) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector2 (0, -72), 2 * Time.deltaTime);

			GameObject.Find ("karti").GetComponent<Image> ().sprite = 
				GameObject.Find (PlayerPrefs.GetString ("chosenCard")).GetComponent<swaper> ().bunga;
		}
		if (PlayerPrefs.GetString("chosenCard").Equals("")) {
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector2 (-262, -72), 2 * Time.deltaTime);

		}

	}
	public void OnPointerClick(PointerEventData eventData){
		//GameObject.Find (PlayerPrefs.GetString ("chosenCard")).GetComponent<swaper> ().swap ();
		PlayerPrefs.SetString ("chosenCard", "");
		Debug.Log(PlayerPrefs.GetString("chosenCard"));
	}
}
