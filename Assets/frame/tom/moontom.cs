using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class moontom : MonoBehaviour, IPointerClickHandler {
	public bool mulai=true;
	Image img;
	Image imgbul;
	public Image panel;
	Transform bul;
	public string hubungan;
	float startpos;
	void Start () {
		img = GameObject.Find("jalansusu").GetComponent<Image> ();
		imgbul = GameObject.Find("bul").GetComponent<Image> ();
		bul = GameObject.Find ("bul").transform;
		startpos = -35f;
		img.color = new Color(img.color.r, img.color.g, img.color.b, 0);
		imgbul.color = new Color(img.color.r, img.color.g, img.color.b, 0);
	}
	void Update(){
		bul.localPosition = 
			Vector3.Lerp (bul.transform.localPosition, new Vector2 (0, mulai ?0: startpos), 2 * Time.deltaTime);
	}
	public void OnPointerClick(PointerEventData eventData){
		mulai = mulai ? false : true;
		GameObject.Find (hubungan).GetComponent<moontom> ().mulai = mulai;
		GameObject.Find ("jalansusu").GetComponent<Image> ().raycastTarget =
			GameObject.Find ("jalansusu").GetComponent<Image> ().raycastTarget ? false : true;
		if (mulai) {
			GameObject.Find ("Text milky").transform.localScale = Vector3.zero;
			GameObject.Find ("Text kembalibul").transform.localScale = Vector3.zero;
		} else {
			GameObject.Find ("Text milky").transform.localScale = new Vector3 (0.06f, 0.06f);
			GameObject.Find ("Text kembalibul").transform.localScale = new Vector3 (0.7f, 0.7f);
		}



		StartCoroutine(FadeImage(mulai));
	}
	IEnumerator FadeImage(bool fadeAway)
	{
		// fade from opaque to transparent
		if (fadeAway)
		{
			// loop over 1 second backwards
			for (float i = 1; i >= 0; i -= Time.deltaTime)
			{
				// set color with i as alpha
				img.color = new Color(img.color.r, img.color.g, img.color.b, i);
				imgbul.color = new Color(img.color.r, img.color.g, img.color.b, i);
				panel.color = new Color(255, 255, 255, i);
				//bul.localPosition = new Vector2 (bul.transform.localPosition.x, startpos * i);
				yield return null;
			}
		}
		// fade from transparent to opaque
		else
		{
			// loop over 1 second

			for (float i = 0; i <= 1; i += Time.deltaTime)
			{
				// set color with i as alpha
				img.color = new Color(img.color.r, img.color.g, img.color.b, i);
				imgbul.color = new Color(img.color.r, img.color.g, img.color.b, i);
				panel.color = new Color(255, 255, 255, i);

				yield return null;
			}
		}
	}
}
