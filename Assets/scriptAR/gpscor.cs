using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gpscor : MonoBehaviour {
	public static gpscor Instance { set; get;}
	public float latitude;
	public float longitude;

	private void Start()
	{
		Instance = this;
		DontDestroyOnLoad (gameObject);
		StartCoroutine (startService ());
	}

	private float nextActionTime = 0.0f;
	public float period = 0.2f;
	public bool regularly=false;
	void Update()
	{
		if (Time.time > nextActionTime && regularly ) {
			nextActionTime += period;
			// execute block of code here
			StartCoroutine (startService ());
		}
		//StartCoroutine (startService ());
		//Debug.Log (latitude.ToString() + " - " + longitude.ToString());
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