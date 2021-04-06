using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disco : MonoBehaviour {

	public int color=1;
	public Image a;
	public bool kchaww;
	public Image mid;
	public Image back;
	public List<Sprite> njobo;
	public List<Sprite> njero;
	public List<AudioClip> clip;
	void Start () {
		color = 1;
	}
	public void setcolor(int a){
		mid.sprite = njobo [color-1];
		color = a;
		back.sprite = njero [color-1];
		chekminion ();
	}
	void chekminion(){
		if (GameObject.Find("prime")) {

			if (color == GameObject.Find("prime").GetComponent<minion>().id) {
				GameObject.Find ("prime").name = "bucin";
				manamusiknya ();
			}
		}
	}
	public void manamusiknya(){
		GameObject ulala = new GameObject();
		AudioSource au= ulala.AddComponent<AudioSource>();
		au.clip = clip [Random.Range (0, clip.Count )];
		au.panStereo = Random.Range (-1, 1);
		au.Play ();
		ulala.SetActive (true);
		Destroy (ulala, 2);
	}
	void Update () {
		if (color==1) {
			a.color = new Color (255, 255, 255);
		}else if (color==2) {
			a.color = new Color (0, 0, 0);
		}else if (color == 3) {
			a.color = new Color (161, 0, 0);
		}else if (color == 4) {
			a.color = new Color (255,210, 0);
		}
		if (kchaww) {
			a.transform.localScale = new Vector3 (20, 20);
			kchaww = false;
		}
		a.transform.localScale = Vector3.Lerp (a.transform.localScale, Vector3.zero, Time.deltaTime * 5);
		if (a.transform.localScale.x<1) {
			a.transform.localScale = Vector3.zero;
		}
	}
}
