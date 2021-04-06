using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class bukatutup : MonoBehaviour, IPointerClickHandler {

	public Sprite melek;
	public Sprite merem;
	public Sprite mringis;
	public Sprite mrongos;
	public Atan mma;
	public Image panel;
	public Transform bambang;
	private Image spriteRenderer;
	void Start () {
		spriteRenderer = GetComponent<Image> ();
		if (spriteRenderer.sprite==null) {
			spriteRenderer.sprite = melek;
		}
		StartCoroutine(ketip());
	}
	bool bambangnaik=false;

	void Update () {
		if (bambangnaik) {
			bambang.transform.localPosition = Vector3.Lerp (bambang.transform.localPosition, Vector3.up * 2000, Time.deltaTime * 3);
		}else
			bambang.transform.localPosition = Vector3.Lerp (bambang.transform.localPosition, Vector3.zero, Time.deltaTime * 1);


	}
	bool buka = true;
	IEnumerator ketip(){
		if (buka && mma.mendekat) {
			
			spriteRenderer.sprite = merem;
			yield return new WaitForSeconds (2);
			buka = false;
		}else if (!buka && mma.mendekat) {
			spriteRenderer.sprite = mringis;
			yield return new WaitForSeconds (0.2f);
			buka = true;
		}else if (buka && !GameObject.Find ("wolo").GetComponent<inigps> ().dalamArea) {
			panel.color = new Color (27, 27, 27);
			spriteRenderer.sprite = melek;
			yield return new WaitForSeconds (2);
			buka = false;
			bambangnaik =  false ;
		} else if (GameObject.Find ("wolo").GetComponent<inigps> ().dalamArea) {
			panel.color = new Color (237, 0, 0);
			spriteRenderer.sprite = mrongos;
			yield return new WaitForSeconds (0.4f);
			bambangnaik =  true;
			buka = true;
		} else {
			panel.color = new Color (27, 27, 27);
			spriteRenderer.sprite = merem;


			yield return new WaitForSeconds (0.2f);
			buka = true;
		}

		StartCoroutine (ketip ());
	}
	public void OnPointerClick(PointerEventData eventData)
	{


	}
}
