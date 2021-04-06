using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coloran : MonoBehaviour {

	public List<Color> colormolor;
	public Color getcolor(){
		int kodeweapon = PlayerPrefs.GetInt ("kodeweapon");
		int levelweapon = PlayerPrefs.GetInt ("levelweapon"+kodeweapon);
		if (levelweapon <= 6) {
			return colormolor [levelweapon];
		} else {
			return colormolor [6];
		}
	}

	public Color getcolor(int wewe){
		int levelweapon = PlayerPrefs.GetInt ("levelweapon"+wewe);
		if (levelweapon <= 6) {
			return colormolor [levelweapon];
		} else {
			return colormolor [6];
		}
	}
}
