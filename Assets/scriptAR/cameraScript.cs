using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cameraScript : MonoBehaviour {

	public GameObject webCameraPlane; 
	public Button fireButton;
	public Button gpsButton;
	public Button torch;
	public anu senj;
	WebCamTexture webCameraTexture;

	// Use this for initialization
	void Start () {
		if (Application.isMobilePlatform) {
			GameObject cameraParent = new GameObject ("camParent");
			cameraParent.transform.position = this.transform.position;
			this.transform.parent = cameraParent.transform;
			cameraParent.transform.Rotate (Vector3.right, 90);
		}

		Input.gyro.enabled = true;

		fireButton.onClick.AddListener (OnButtonDown);
		gpsButton.onClick.AddListener (gpsDown);


		 webCameraTexture = new WebCamTexture();
		webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
		webCameraTexture.Play();


		Input.compensateSensors = false;
		Input.gyro.updateInterval = 0.01F;


	}
	bool bigg=false;
	void gpsDown(){
		Debug.Log ("kr");
		GameObject.Find ("wolo").GetComponent<inigps> ().gpsf ();
		bigg = true;
	}


	void OnButtonDown(){

		senj.naik = true;
	


		//GetComponent<AudioSource> ().Play ();
		//Debug.Log ("alfkalfkalf");


	}

	// Update is called once per frame
	void Update () {







		Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
		this.transform.localRotation = cameraRotation;

	

		if (bigg) {
			gpsButton.transform.localScale = Vector3.Lerp (gpsButton.transform.localScale, new Vector3(8.89f,51.81f,9.29f), 3f * Time.deltaTime);
			if (gpsButton.transform.localScale.x>=8.87f) {
				gpsButton.transform.localScale = new Vector3 (0.21f,1.23f,0.22f);
				bigg = false;
			}
		}

	

	}









}
