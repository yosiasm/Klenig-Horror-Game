using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class inigps : MonoBehaviour {
	public float objLongitude=0;
	public float objLatitude=0;
	float myLongitude=0;
	float myLatitude=0;
	public bool dalamArea=false;
	public bool hit=false;
	public Atan atan;
	public int target;
	public Transform gerak;
	public gantiskin skincare;

	void Start () {
		dalamArea = false;
		hit = false;
		target = PlayerPrefs.GetInt ("kodekembang");
		skincare.gantikah = true;
		//StartCoroutine (GetCoordinates ());
		//offset = Random.Range(0, 0.0009f);
	}
	

	void Update () {
		
		//PlayerPrefs.SetString ("kkk", "ekkk");
		//Debug.Log(PlayerPrefs.GetString("kkk"));
		checkAnu ();

		//iol = iol>100 ? 0 : iol;
		gpsf ();

		if (hit || objLatitude == 0) {
			if (hit) {
				gerak.transform.localPosition = new Vector3( UnityEngine.Random.Range (56, 100),UnityEngine.Random.Range (65,115),UnityEngine.Random.Range (-30,30));
				if (target - hitungkembang <= 0) {
					PlayerPrefs.SetInt ("jumlahbintang", PlayerPrefs.GetInt ("jumlahbintang") + 1);
					PlayerPrefs.SetFloat ("lat" + PlayerPrefs.GetInt ("jumlahbintang"), objLatitude);
					PlayerPrefs.SetFloat ("lon" + PlayerPrefs.GetInt ("jumlahbintang"), objLongitude);



					int randu = (int)UnityEngine.Random.Range (0, 11);
					if (randu == 4) {
						PlayerPrefs.SetInt ("stokkembang", PlayerPrefs.GetInt ("stokkembang") + 1);
						PlayerPrefs.SetInt ("barukembang", 1);
					} else if (randu == 5) {
						PlayerPrefs.SetInt ("stokweapon", PlayerPrefs.GetInt ("stokweapon") + 1);
						PlayerPrefs.SetInt ("baruweapon", 1);
					} else if (randu == 7) {
						PlayerPrefs.SetInt ("kodejurney", PlayerPrefs.GetInt ("kodejurney") + 1);
						PlayerPrefs.SetInt ("barujurney", 1);
					}



					objLatitude = PlayerPrefs.GetFloat ("lat") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
					objLongitude = PlayerPrefs.GetFloat ("long") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
					hitungkembang = -1;
					int kodeweapon = PlayerPrefs.GetInt ("kodeweapon");
					int levelweapon = PlayerPrefs.GetInt ("levelweapon" + kodeweapon);
					PlayerPrefs.SetInt ("levelweapon" + kodeweapon, levelweapon + 1);
				} else {
					hitungkembang++;
					skincare.gantikah = true;
				}
			}

			if (objLatitude == 0) {
				objLatitude = PlayerPrefs.GetFloat ("lat") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
				objLongitude = PlayerPrefs.GetFloat ("long") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
			}

			hit = false;
		}

		//calculate the distance between where the player was when the app started and where they are now.
		//Calc (myLatitude, myLongitude, objLatitude, objLongitude);



	}
	public int hitungkembang=-1;
	int countcourutine =0;
	IEnumerator GetCoordinates()
	{
		//while true so this function keeps running once started.
		countcourutine++;
			
			// check if user has location service enabled
			if (!Input.location.isEnabledByUser)
				yield break;
			iol = 1;
			// Start service before querying location
			Input.location.Start ();
			iol = 2;
			// Wait until service initializes
			int maxWait = 2;
			while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
				yield return new WaitForSeconds (1);
				maxWait--;
			}
			iol = 3;

			// Service didn't initialize in 20 seconds
			if (maxWait < 1) {
				print ("Timed out");
			StartCoroutine (GetCoordinates ());
			}

			// Connection has failed
			if (Input.location.status == LocationServiceStatus.Failed) {
				iol = 4;
				print ("Unable to determine device location");
			StartCoroutine (GetCoordinates ());
			} else {
				// Access granted and location value could be retrieved
				yield return new WaitForSeconds(1);
				//print ("Location: " + (Input.location.lastData.latitude) + " " + (Input.location.lastData.longitude) + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);


				PlayerPrefs.SetFloat ("lat", Input.location.lastData.latitude);
				PlayerPrefs.SetFloat ("long", Input.location.lastData.longitude);
				iol = 5;
				//if original value has not yet been set save coordinates of player on app start
			//	longg = Input.location.lastData.longitude;
			//	lattt = Input.location.lastData.latitude;
				//iol++;



			}

			//Input.location.Stop();

	}

	public float distance;
	public void Calc(float lat1, float lon1, float lat2, float lon2)
	{

		var R = 6378.137; // Radius of earth in KM
		var dLat = lat2 * Mathf.PI / 180 - lat1 * Mathf.PI / 180;
		var dLon = lon2 * Mathf.PI / 180 - lon1 * Mathf.PI / 180;
		float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
			Mathf.Cos(lat1 * Mathf.PI / 180) * Mathf.Cos(lat2 * Mathf.PI / 180) *
			Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
		var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
		distance = (float)(R * c);
		distance = distance * 1000f; // meters
		//set the distance text on the canvas


	}

	void gps(){
		if (iol==5||countcourutine>12) {

			StopAllCoroutines ();
			iol = 0;
			countcourutine = 0;
		}
		if (iol==0) {
			if (!dalamArea) {
				StartCoroutine (GetCoordinates ());
			}

		}



		
	}
	public void gpsf(){
		try{
			gps();
		}catch(Exception e){
			errr = e.ToString ();
		}

	}


	string  fileName = "debug.txt";

	void tulis(string filename , string ww)
	{
		//if (File.Exists(fileName))
		//{
		//	Debug.Log(fileName+" already exists.");
		//	return;
		///}
		filename=Application.persistentDataPath + filename;
		var sr = File.CreateText(filename);
		sr.WriteLine (ww);
		sr.Close();



	}
	public string errr;
	public string baca(string namafile){
		namafile = Application.persistentDataPath + namafile;
		if(File.Exists(namafile)){
			var sr = File.OpenText(namafile);
			var line = sr.ReadLine();
			string ret=null;
			while(line != null){
				ret = ret + line;// prints each line of the file
				line = sr.ReadLine();
			}  

			return ret==null ? "0" : ret;
		} else {
			return "0";
		}
	}

	float smply(float a){
		float percision = 100000f;
		a = Math.Abs (a);
		return (a - (float)Math.Truncate (a)) * percision;
	}

	public float luasArea=5f;
	void checkAnu(){
		if (atan.getdistance () <= luasArea && PlayerPrefs.GetFloat("lat") !=0 ) {
			dalamArea = true;
		} else {
			dalamArea = false;
		}
	}
		
	public int iol=0;
		
}
