using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Atan : MonoBehaviour {
	public inigps gps;
	public Transform cam;
	public float bear = 0;
	public Transform handel;
	//public GameObject a;

	void Start(){
		StartCoroutine (waktumendekat ());
	}
	// Update is called once per frame
	void Update () {
		//float atan = Math.Atan (gps.myLongitude - gps.objLongitude / gps.myLatitude - gps.objLatitude);
		//Vector3 tar = sa.transform.localPosition;


		//Debug.Log(degree);
		Vector3 eulerRotation = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, 
			                        -cam.transform.eulerAngles.z - 90 + (float)bearing (PlayerPrefs.GetFloat ("lat"), PlayerPrefs.GetFloat ("long"), gps.objLatitude, gps.objLongitude) + cam.transform.eulerAngles.y);

		transform.rotation = Quaternion.Euler(eulerRotation);
		pendekatan ();



	}
	//float rot=1;
	public bool mendekat=false;
	public float asd=34;
	void pendekatan(){
		//gps.objLongitude = asd;

		float tambah = 0.00001f*Time.deltaTime;
		float sudut = -cam.transform.eulerAngles.z - 90 + (float)bearing (PlayerPrefs.GetFloat ("lat"), PlayerPrefs.GetFloat ("long"), gps.objLatitude, gps.objLongitude) + cam.transform.eulerAngles.y;
		//sudut = asd;
		//if (rot > Time.time) {
		float wktu = UnityEngine.Random.Range(2,5);
		//gps.objLatitude= Mathf.Lerp(gps.objLatitude,PlayerPrefs.GetFloat ("lat"),Time.deltaTime/wktu);
		//gps.objLongitude= Mathf.Lerp(gps.objLongitude,PlayerPrefs.GetFloat ("long"),Time.deltaTime/wktu);
			if (((sudut > -15 && sudut < 15) || (sudut < -340 && sudut > -380)) && !gps.dalamArea) {
				mendekat = true;
				//gps.objLatitude = ((PlayerPrefs.GetFloat ("lat") - gps.objLatitude)) >= 0 ? gps.objLatitude + tambah : gps.objLatitude - tambah;
				//gps.objLongitude = ((PlayerPrefs.GetFloat ("long") - gps.objLongitude)) >= 0 ? gps.objLongitude + tambah : gps.objLongitude - tambah;
			gps.objLatitude= Mathf.Lerp(gps.objLatitude,PlayerPrefs.GetFloat ("lat"),Time.deltaTime/wktu);
			gps.objLongitude= Mathf.Lerp(gps.objLongitude,PlayerPrefs.GetFloat ("long"),Time.deltaTime/wktu);

				bear = 1;
			handel.localScale = Vector3.Lerp (handel.localScale, new Vector3(8.5f*gps.luasArea/(float)getdistance(),handel.localScale.y) , Time.deltaTime * 2.4f);
			} else {
				bear = 0;	
				mendekat = false;
			handel.localScale = Vector3.Lerp (handel.localScale, new Vector3(0,handel.localScale.y) , Time.deltaTime * 2.4f);
			}

		//} else
			//rot = Time.time + 1;


	}
	int timer=0;
	IEnumerator waktumendekat(){
		while (true) {
			yield return new WaitForSeconds (1);
			if (mendekat) {
				timer++;	
			} else
				timer = 0;

		}
	}

	public double getdistance(){
		//double a = (Calc (PlayerPrefs.GetFloat("lat"), PlayerPrefs.GetFloat("long"), gps.objLatitude, gps.objLongitude) );
		double a = pitagors();
		if (a > 15) {
			gps.objLatitude = PlayerPrefs.GetFloat("lat") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
			gps.objLongitude = PlayerPrefs.GetFloat("long") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
		}
		if (timer>=5) {
			gps.objLatitude = PlayerPrefs.GetFloat("lat") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
			gps.objLongitude = PlayerPrefs.GetFloat("long") + UnityEngine.Random.Range (-0.00007f, 0.00007f);
			timer = 0;
		}
		return a ;
	}

	float meter(float a){
		float percision = 10000f;
		a=a*percision;
		a = Math.Abs (a);
		return (a - (float)Math.Truncate (a)) * 10;
	}
	public double pitagors(){
		return Math.Sqrt (Math.Pow (meter(PlayerPrefs.GetFloat ("lat") - gps.objLatitude),2) + Math.Pow (meter(PlayerPrefs.GetFloat ("long") - gps.objLongitude),2));
	}
	public double Calc(float lat1, float lon1, float lat2, float lon2)
	{
		double jar = 0;
		var R = 6378.137; // Radius of earth in KM
		var dLat = lat2 * Mathf.PI / 180 - lat1 * Mathf.PI / 180;
		var dLon = lon2 * Mathf.PI / 180 - lon1 * Mathf.PI / 180;
		float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
			Mathf.Cos(lat1 * Mathf.PI / 180) * Mathf.Cos(lat2 * Mathf.PI / 180) *
			Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
		var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
		jar = (float)(R * c);
		jar = jar * 1000f; // meters
		return jar;
		//set the distance text on the canvas


	}
	private double distance(double lat1, double lon1, double lat2, double lon2, char unit) {
		if ((lat1 == lat2) && (lon1 == lon2)) {
			return 0;
		}
		else {
			double theta = lon1 - lon2;
			double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
			dist = Math.Acos(dist);
			dist = rad2deg(dist);
			dist = dist * 60 * 1.1515;
			if (unit == 'K') {
				dist = dist * 1.609344;
			} else if (unit == 'N') {
				dist = dist * 0.8684;
			}
			return (dist);
		}
	}

	//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	//::  This function converts decimal degrees to radians             :::
	//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	private double deg2rad(double deg) {
		return (deg * Math.PI / 180.0);
	}

	//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	//::  This function converts radians to decimal degrees             :::
	//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	private double rad2deg(double rad) {
		return (rad / Math.PI * 180.0);
	}

	private double bearing(double lat1, double long1, double lat2,
		double long2) {

		double dLon = (long2 - long1);

		double y = Math.Sin(dLon* Math.PI / 180.0) * Math.Cos(lat2* Math.PI / 180.0);
		double x = Math.Cos(lat1* Math.PI / 180.0) * Math.Sin(lat2* Math.PI / 180.0) - Math.Sin(lat1* Math.PI / 180.0)
			* Math.Cos(lat2* Math.PI / 180.0) * Math.Cos(dLon* Math.PI / 180.0);

		double brng = Math.Atan2(y, x);

		brng = rad2deg(brng);
		//brng = (brng + 360) % 360;
		//brng = 360 - brng; // count degrees counter-clockwise - remove to make clockwise

		return brng;
	}
}
