using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class bintang : MonoBehaviour {
	public int jur =35;
	public Sprite bin;
	int i;
	void Start () {
		jur = PlayerPrefs.GetInt ("jumlahbintang");

		Vector3 starte = new Vector3 (0,0,0);
		float lon = 0;
		float lat = 0;
		for (i = 1; i <= jur; i++) {

			lon =S (PlayerPrefs.GetFloat("lon"+i));
			lat = S (PlayerPrefs.GetFloat("lat"+i));

			if (pitahoras (lat - S (PlayerPrefs.GetFloat ("lon" + (i - 1))), lon - S (PlayerPrefs.GetFloat ("lat" + i)))) {
				buatbintang (lat + starte.x, lon + starte.y);
			} else {
				starte = new Vector3 (UnityEngine.Random.Range (-30, 30), UnityEngine.Random.Range (-30, 30));
				buatbintang (lat + starte.x, lon + starte.y);
			}

		}



	}
	void buatbintang(float lat, float lon){
		GameObject NewObj = new GameObject(); //Create the GameObject
		NewObj.name="bintang"+i;
		Image NewImage = NewObj.AddComponent<Image>(); //Add the Image Component script
		NewImage.sprite = bin; //Set the Sprite of the Image Component on the new GameObject
		NewObj.GetComponent<RectTransform>().SetParent(this.transform); //Assign the newly created Image GameObject as a Child of the Parent Panel.
		NewObj.SetActive(true); //Activate the GameObject
		NewObj.transform.localScale = new Vector3(0.019f,0.019f,0.019f);
		NewObj.transform.localPosition = new Vector3(lat,lon);
		NewObj.AddComponent<fadeikut> ();
	}
	float S(float a){
		float percision = 10000f;
		a=a*percision;
		a = Mathf.Sqrt(a*a);
		return (a - (float)Math.Truncate (a)) * 10*3;
	}
	bool pitahoras(float a,float b){
		if (Mathf.Sqrt ((a * a) + (b * b)) <= 30) {
			return true;	
		}
		return false;
	}
	
	// Update is called once per frame
	void Update () {


	}
}
