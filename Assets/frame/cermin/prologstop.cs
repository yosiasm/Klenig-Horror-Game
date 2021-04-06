using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;

public class prologstop : MonoBehaviour , IPointerClickHandler{

	// Use this for initialization
	void Start () {
		
	}
	public void OnPointerClick(PointerEventData eventData)
	{
		PlayerPrefs.SetInt ("prolog", 1);

	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("prolog")==1) {
			SceneManager.LoadScene(0);	
		}

	}
}
