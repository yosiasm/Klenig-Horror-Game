using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mengakhiri : MonoBehaviour, IPointerClickHandler {

	public GameObject tom;
	void Start () {
		if (!(PlayerPrefs.GetInt("stokkembang")>=8 && PlayerPrefs.GetInt("stokweapon")>=13 && PlayerPrefs.GetInt("kodejurney")>=8)) {
			Destroy (tom);
		}
	}
	public void OnPointerClick(PointerEventData eventData)
	{
		PlayerPrefs.SetInt ("akhir", 1);

	}
	void Update () {
		
	}
}
