using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class gpsplacing : MonoBehaviour {
	public bool moving = false;
	public bool custom =false;
	public float lati =0;
	public float longi =0;
	private float offset;
	public float latitude;
	public float longitude;
	public GameObject target;
	float xTr;
	float zTr;

	public bool showStatus;
	public string textObjNameForStatus;
	Text text;

	void settext(){
		if (showStatus) {
			text.text = "lat:" + latitude.ToString () + " long:" + longitude.ToString () + 
				" x:" +transform.localPosition.x.ToString() + " z:" +transform.localPosition.z.ToString();	
		}

	}
	void convert(){
		float percision = 10000f;
		xTr = (latitude - (float)Math.Truncate (latitude)) * percision;
		zTr = (longitude - (float)Math.Truncate (longitude)) * percision;

	}
	void Start () {
		if (showStatus) {
			text = GameObject.Find (textObjNameForStatus).GetComponent<Text> ();	
			Debug.Log (textObjNameForStatus +"-"+ text.text);
		}

		StartCoroutine (startService ());
		//offset = Random.Range(0, 0.0009f);
		if (custom) {
			latitude = lati;
			longitude = longi;
		} 
		//transform.localPosition = Quaternion.AngleAxis(longitude, -Vector3.up) * Quaternion.AngleAxis(latitude, -Vector3.right) * new Vector3(0,0,1);	
		convert ();
		transform.localPosition = new Vector3 (xTr,0,zTr);
		target.transform.localPosition = new Vector3 (xTr,0,zTr);
		settext ();
	}
	
	private float nextActionTime = 0.0f;
	public float period = 0.1f;
	public bool regularly=false;
	void Update () {

		if (Time.time > nextActionTime && regularly ) {
			nextActionTime += period;
			// execute block of code here

			if (moving) {
				StartCoroutine (startService ());
				convert ();
				transform.localPosition = new Vector3 (xTr,0,zTr);
				if (target.transform.localPosition.x==0) {
					target.transform.localPosition = new Vector3 (xTr,0,zTr+20);
				}
				//transform.localPosition = Quaternion.AngleAxis(longitude, -Vector3.up) * Quaternion.AngleAxis(latitude, -Vector3.right) * new Vector3(0,0,1);	
			}

		}
		settext ();
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
