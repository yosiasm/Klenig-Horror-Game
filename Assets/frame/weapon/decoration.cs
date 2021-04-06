using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decoration : MonoBehaviour {

	public Image sun;
	public Image kris1;
	public Image kris2;
	public Image sem1;
	public Image sem2;
	public Image kem1;
	public Image kem2;
	public Image kema;
	public Image kemb;
	public Image war;
	public Image chick1;
	public Image chick2;
	public bool momo;
	public Transform marker;
	public GameObject dada;
	void Start () {
		if (PlayerPrefs.GetInt ("stokkembang") >= 8 && PlayerPrefs.GetInt ("stokweapon") >= 13 && PlayerPrefs.GetInt ("kodejurney") >= 8) {

			dada.AddComponent<futar> ();
			dada.GetComponent<futar> ().speed=11;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("stokkembang")>=8 && PlayerPrefs.GetInt("stokweapon")>=13 && PlayerPrefs.GetInt("kodejurney")>=8) {
			if (PlayerPrefs.GetInt("akhir")==0) {
				PlayerPrefs.SetInt ("barujurney", 1);
			}
			if (marker.localScale.x > 2) {
				sun.transform.localScale = Vector3.Lerp (sun.transform.localScale, new Vector3 (0.3f, 0.3f), Time.deltaTime * 3);
				sun.transform.localPosition = Vector3.Lerp (sun.transform.localPosition, new Vector3 (0, 320), Time.deltaTime * 3);
				if (sun.transform.localScale.x > 0.2f) {
					kris1.transform.localScale = Vector3.Lerp (kris1.transform.localScale, new Vector3 (0.3f, 0.3f), Time.deltaTime * 3);
					kris2.transform.localScale = Vector3.Lerp (kris2.transform.localScale, new Vector3 (-0.3f, 0.3f), Time.deltaTime * 3);

					kris1.transform.localPosition = Vector3.Lerp (kris1.transform.localPosition, new Vector3 (-228, 190), Time.deltaTime * 3);
					kris2.transform.localPosition = Vector3.Lerp (kris2.transform.localPosition, new Vector3 (228, 190), Time.deltaTime * 3);

					if (kris1.transform.localScale.x > 0.2f) {
						sem1.transform.localScale = Vector3.Lerp (sem1.transform.localScale, new Vector3 (0.3f, 0.3f), Time.deltaTime * 3);
						sem2.transform.localScale = Vector3.Lerp (sem2.transform.localScale, new Vector3 (-0.3f, 0.3f), Time.deltaTime * 3);

						sem1.transform.localPosition = Vector3.Lerp (sem1.transform.localPosition, new Vector3 (147, 262), Time.deltaTime * 3);
						sem2.transform.localPosition = Vector3.Lerp (sem2.transform.localPosition, new Vector3 (-147, 262), Time.deltaTime * 3);

						if (sem1.transform.localScale.x > 0.2f) {
							kem1.transform.localScale = Vector3.Lerp (kem1.transform.localScale, new Vector3 (-0.3f, -0.3f), Time.deltaTime * 3);
							kem2.transform.localScale = Vector3.Lerp (kem2.transform.localScale, new Vector3 (-0.3f, 0.3f), Time.deltaTime * 3);

							kem1.transform.localPosition = Vector3.Lerp (kem1.transform.localPosition, new Vector3 (-161, 443), Time.deltaTime * 3);
							kem2.transform.localPosition = Vector3.Lerp (kem2.transform.localPosition, new Vector3 (161, 443), Time.deltaTime * 3);
							if (kem2.transform.localScale.y > 0.2f) {
								kema.transform.localScale = Vector3.Lerp (kema.transform.localScale, new Vector3 (0.231f, 0.231f), Time.deltaTime * 3);
								kemb.transform.localScale = Vector3.Lerp (kemb.transform.localScale, new Vector3 (-0.231f, 0.231f), Time.deltaTime * 3);
								war.transform.localScale = Vector3.Lerp (war.transform.localScale, new Vector3 (0.3f, 0.3f), Time.deltaTime * 3);

								kema.transform.localPosition = Vector3.Lerp (kema.transform.localPosition, new Vector3 (-300, 48.6f), Time.deltaTime * 3);
								kemb.transform.localPosition = Vector3.Lerp (kemb.transform.localPosition, new Vector3 (300, 48.6f), Time.deltaTime * 3);
								war.transform.localPosition = Vector3.Lerp (war.transform.localPosition, new Vector3 (0, -318f), Time.deltaTime * 3);
								if (war.transform.localScale.x > 0.2) {
									chick1.transform.localScale = Vector3.Lerp (chick1.transform.localScale, new Vector3 (0.3f, 0.3f), Time.deltaTime * 3);
									chick2.transform.localScale = Vector3.Lerp (chick2.transform.localScale, new Vector3 (-0.3f, 0.3f), Time.deltaTime * 3);

									chick1.transform.localPosition = Vector3.Lerp (chick1.transform.localPosition, new Vector3 (-228, -199), Time.deltaTime * 3);
									chick2.transform.localPosition = Vector3.Lerp (chick2.transform.localPosition, new Vector3 (228f, -199), Time.deltaTime * 3);

								}

							}
						}
					}
				}
			}
		} else {
			sun.transform.localScale=Vector3.zero;
			kris1.transform.localScale=Vector3.zero;
			kris2.transform.localScale=Vector3.zero;
			sem1.transform.localScale=Vector3.zero;
			sem2.transform.localScale=Vector3.zero;
			kem1.transform.localScale=Vector3.zero;
			kem2.transform.localScale=Vector3.zero;
			kema.transform.localScale=Vector3.zero;
			kemb.transform.localScale=Vector3.zero;
			war.transform.localScale=Vector3.zero;
			chick1.transform.localScale=Vector3.zero;
			chick2.transform.localScale=Vector3.zero;
			PlayerPrefs.SetInt ("barujurney", 0);
			
		}
	}
}
