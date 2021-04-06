using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swaptabir : MonoBehaviour {

	public int index;
	public Sprite omegad;
	public Sprite A;
	public Text locked;

	void Start () {
		if (PlayerPrefs.GetInt("kodejurney")==index) {
			GetComponent<Image> ().sprite = omegad;

		}else if (PlayerPrefs.GetInt("kodejurney")>index) {
			GetComponent<Image> ().sprite = A;
		}else if (PlayerPrefs.GetInt("kodejurney")<index) {
			locked.transform.localScale = new Vector3(0.4170644f,0.68f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
