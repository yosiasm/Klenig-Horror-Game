﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class summon : MonoBehaviour {

	public float latitude;
	public float longitude;
	float xTr;
	float zTr;
	void convert(){
		float percision = 10000f;
		xTr = (latitude - (float)Math.Truncate (latitude)) * percision;
		zTr = (longitude - (float)Math.Truncate (longitude)) * percision;
	}

	void Start () {
		DontDestroyOnLoad (gameObject);
		StartCoroutine (startService ());
		convert ();
		transform.localPosition = new Vector3 (xTr,0,zTr);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	IEnumerator startService()
	{


		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser)
			yield break;

		// Start service before querying location
		Input.location.Start();

		// Wait until service initializes
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		// Service didn't initialize in 20 seconds
		if (maxWait < 1)
		{
			print("Timed out");
			yield break;
		}

		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed)
		{
			print("Unable to determine device location");
			yield break;
		}
		else
		{
			// Access granted and location value could be retrieved
			print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
		}
		longitude = Input.location.lastData.longitude;
		latitude = Input.location.lastData.latitude;


		// Stop service if there is no need to query location updates continuously
		//Input.location.Stop();
	}
}
