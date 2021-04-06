using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class jumpalitan : MonoBehaviour {

	public List<AudioClip> clip;
	public List<Sprite> sprit;
	public AudioSource gg;
	public Image wadah;
	public bool muncul;
	public inigps gps;
	float waktu;
	void Start () {
		wadah.sprite = sprit [Random.Range (0, sprit.Count)];
		int a = Random.Range (0, 10) > 5 ? 0 : 1;
		if (a==1) {
			gg.pitch = 0.41f;
		}
		gg.clip=clip[a];
		if (Random.Range(0,10)>5) {
			wadah.color = new Color (255, 0, 0);
		}
		StartCoroutine (waktum ());
	}
	
	// Update is called once per frame
	bool play1=true;
	void Update () {
		
		if (timer==31) {
			muncul = true;	
		}
		if (muncul) {
	
			transform.localScale = Vector3.Lerp(transform.localScale, new Vector3 (0.7726596f, 0.7726596f),Time.deltaTime*7);

			if (!gg.isPlaying && play1) {
				StartCoroutine (tunggu ());
				gg.Play ();	
				waktu = Time.time + 1.5f;
				play1 = false;

				int randu =UnityEngine.Random.Range (0, 17);
				if (randu == 4 && PlayerPrefs.GetInt ("stokkembang")>1) {
					PlayerPrefs.SetInt ("stokkembang", PlayerPrefs.GetInt ("stokkembang") - 1);
					PlayerPrefs.SetInt ("barukembang", 1);
				} else if (randu == 5 && PlayerPrefs.GetInt ("stokweapon")>1) {
					PlayerPrefs.SetInt ("stokweapon", PlayerPrefs.GetInt ("stokweapon") - 1);
					PlayerPrefs.SetInt ("baruweapon", 1);
				} else if (randu == 7 && PlayerPrefs.GetInt ("kodejurney")>1) {
					PlayerPrefs.SetInt ("kodejurney", PlayerPrefs.GetInt ("kodejurney") - 1);
					PlayerPrefs.SetInt ("barujurney", 1);
				}
				PlayerPrefs.SetInt ("kodesenjata", 0);
				PlayerPrefs.SetInt ("kodekembang", 0);
			}
			if (waktu<Time.time) {
				wadah.color = new Color (0, 0, 0);
				transform.localScale = new Vector3 (5,5);
			}



		} else {
			transform.localScale = Vector3.zero;
		}
	}
	IEnumerator tunggu(){
		yield return new WaitForSeconds (6);

		AsyncOperation ass = SceneManager.LoadSceneAsync(0);
	
	}

	int timer=0;
	IEnumerator waktum(){
		while (true) {
			yield return new WaitForSeconds (1);
			if (gps.dalamArea) {
				timer++;
				if (gps.hit) {
					timer = 0;
				}
			} else
				timer = 0;

		}
	}
}
