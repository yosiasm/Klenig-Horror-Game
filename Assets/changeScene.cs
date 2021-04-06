using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class changeScene : MonoBehaviour, IPointerClickHandler {
	public int num;
	public Transform chy;
	public Transform torch;
	bool besar = false;
	public tompon tompel;
	public tomcard tomket;
	void Start(){
		chy.transform.localScale = new Vector2 (50, 50);
	}
	float timer;
	bool ex;
	void Update(){
		if (timer < Time.time) {
			ex = false;
		}

		if (Input.GetKeyDown (KeyCode.Escape)&& num==0) {
			torch.localScale =new Vector3 (trxs, trys);
			besar = besar ? false : true;
			StartCoroutine (tunggu ());
			Debug.Log("change scene");
		}if (Input.GetKeyDown (KeyCode.Escape)&& num!=0) {
			if (tomket !=null) {
				if (ex) {
					Application.Quit (); 
				}
				if (!ex) {
					timer = Time.time + 1;
					ex = true;
					tompel.mulai = false;
					tomket.mulai = false;
				}

			}

		}
		
		if (besar) {
			
			chy.localScale = Vector3.Lerp (chy.localScale, new Vector3 (100, 100, 0), Time.deltaTime * 2);	
			if (chy.localScale.x > 2) {
				chy.GetComponent<Image> ().CrossFadeAlpha (255, Time.deltaTime * 3, true);
			}

		} else {
			chy.localScale = Vector3.Lerp (chy.localScale, new Vector3 (0, 0, 0), Time.deltaTime * 2);	
			if (chy.localScale.x <= 4) {
				chy.GetComponent<Image> ().CrossFadeAlpha (0, Time.deltaTime * 3, true);
			}

		}

	}
	public float trxs;
	public float trys;
	public void OnPointerClick(PointerEventData eventData)
	{
		torch.localScale =new Vector3 (trxs, trys);
		besar = besar ? false : true;
		StartCoroutine (tunggu ());
		Debug.Log("change scene");

	}
	IEnumerator tunggu(){
		yield return new WaitForSeconds (0.5f);

		AsyncOperation ass = SceneManager.LoadSceneAsync(num);
		while (!ass.isDone) {
			yield return null;
		}
	}
}
