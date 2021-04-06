using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unittest : MonoBehaviour {

	public Text tex;
	public inigps gpd;
	public GameObject c;
	public bool warningmode;
	void Start () {
		
	}
	IEnumerator gpsjumper(){
		yield return new WaitForSeconds (10);
		if (PlayerPrefs.GetFloat("lat") ==0) {
			PlayerPrefs.SetFloat ("lat", 0.00001f);
			PlayerPrefs.SetFloat ("long", 0.000001f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (warningmode) {
			tex.text = "";
			if (!Input.location.isEnabledByUser)
				tex.text = "hidupkan GPS!";
			if (PlayerPrefs.GetFloat("lat") ==0) {
				tex.text =  " menunggu GPS!";
				StartCoroutine (gpsjumper ());
			}
			if (!Input.gyro.enabled) 
				tex.text =  " hidupkan Gyroscope!";
			

			
		} else {
			
			string	lat = PlayerPrefs.GetFloat ("lat") + "";
			string longg = PlayerPrefs.GetFloat ("long") + "";
			string stokwe = PlayerPrefs.GetInt ("stokweapon") + "";
			string stokkem = PlayerPrefs.GetInt ("stokkembang") + "";
			string stokjur = PlayerPrefs.GetInt ("kodejurney") + "";
			string kdwe = PlayerPrefs.GetInt ("kodesenjata") + "";
			string kdkem = PlayerPrefs.GetInt ("kodekembang") + "";
			string levelwe = PlayerPrefs.GetInt ("levelweapon" + kdwe) + "";
			int iol = gpd.iol;
			string err = gpd.errr;
			tex.text = "lat" + lat + " \n long" + longg + " \n stweapon " + stokwe + " \n stkembang " + stokkem + " \n kodejurney " + stokjur
			+ " \n kdweapon " + kdwe + " \n kdkembang " + kdkem + " \n levelweapon " + levelwe + " \n iol " + iol + " \n err " + err + " \n yq " + Input.gyro.attitude.y + " \n y " + c.transform.localRotation.y;
		}
	}
}
