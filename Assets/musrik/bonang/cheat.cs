using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class cheat : MonoBehaviour,IPointerClickHandler {
	int a;
	public void OnPointerClick(PointerEventData eventData){
		a++;
		Debug.Log (a);
		if (a==20) {
			a = 0;
			if (PlayerPrefs.GetInt ("stokkembang") == 0) {

				PlayerPrefs.SetInt ("stokkembang", 4);
				PlayerPrefs.SetInt ("stokweapon", 4);
				PlayerPrefs.SetInt ("kodejurney", 4);

				PlayerPrefs.SetInt ("barukembang", 1);
				PlayerPrefs.SetInt ("baruweapon", 1);
				PlayerPrefs.SetInt ("barujurney", 1);
				SceneManager.LoadScene(0);
			} else if (PlayerPrefs.GetInt ("stokkembang") == 4) {
				PlayerPrefs.SetInt ("stokkembang", 8);
				PlayerPrefs.SetInt ("stokweapon", 13);
				PlayerPrefs.SetInt ("kodejurney", 8);

				PlayerPrefs.SetInt ("barukembang", 1);
				PlayerPrefs.SetInt ("baruweapon", 1);
				PlayerPrefs.SetInt ("barujurney", 1);
				SceneManager.LoadScene(0);
			} else {
				PlayerPrefs.SetInt ("stokkembang", 0);
				PlayerPrefs.SetInt ("stokweapon", 0);
				PlayerPrefs.SetInt ("kodejurney", 0);

				PlayerPrefs.SetInt ("barukembang", 1);
				PlayerPrefs.SetInt ("baruweapon", 1);
				PlayerPrefs.SetInt ("barujurney", 1);
				SceneManager.LoadScene(0);
			}
		}
	}
}
