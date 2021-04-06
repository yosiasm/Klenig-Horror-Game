using UnityEngine;
using System.Collections;

public class gerak : MonoBehaviour {


	// Use this for initialization
	void Start () {
		transform.localPosition = new Vector3( Random.Range (56, 100),Random.Range (65,115),Random.Range (-30,30));
		StartCoroutine ("Move");
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.forward * 4f * Time.deltaTime); //jarak
		GameObject.Find("contain").GetComponent<Renderer>().enabled = gameObject.GetComponent<inigps>().dalamArea;

		if ((transform.localPosition.x > 100 || transform.localPosition.x < 56)) {
			transform.localPosition = new Vector3( Random.Range (56, 100),Random.Range (65,115),Random.Range (-30,30));
		}
		if ((transform.localPosition.z > 30 || transform.localPosition.z < -30)) {
			transform.localPosition = new Vector3( Random.Range (56, 100),Random.Range (65,115),Random.Range (-30,30));
		}
		if ((transform.localPosition.y > 115 || transform.localPosition.y < 65)) {
			transform.localPosition = new Vector3( Random.Range (56, 100),Random.Range (65,115),Random.Range (-30,30));
		}

		
	}

	IEnumerator Move() {


		while (true) {
			yield return new WaitForSeconds (Random.Range (1,3.5f));
			transform.eulerAngles += new Vector3 (0, Random.Range(-360,360), 0);//putar
		}
	}
}
