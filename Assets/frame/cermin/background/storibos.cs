using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class storibos : MonoBehaviour, IPointerClickHandler {

	public List<Sprite> sprit;
	public List<string> story;
	public Text text;
	public bool naik;
	public int counter;
	public Transform penulis;
	Vector3 strt;
	void Start () {
		GetComponent<Image>().sprite = sprit[(int)Random.Range(0,sprit.Count-1)];
		text.text = story [0];

		strt = penulis.localPosition;

	}
	
	// Update is called once per frame
	void Update () {
		if (naik) {
			
			transform.localPosition = Vector3.Lerp (transform.localPosition, Vector3.zero, Time.deltaTime*3);
		} else {
			
			transform.localPosition = Vector3.Lerp (transform.localPosition, Vector3.down * 1500, Time.deltaTime*3);
			text.text = story [0];
			counter = 0;
		}

	}
	public void OnPointerClick(PointerEventData eventData){
		GetComponent<Image>().sprite = sprit[(int)Random.Range(0,sprit.Count-1)];
		counter++;
		if (counter < story.Count) {
			text.text = story [counter];	
		} else {
			naik = false;
			penulis.localPosition = strt;
		}

		penulis.localPosition = new Vector3 (penulis.localPosition.x + Random.Range (-4, 4), penulis.localPosition.y + Random.Range (-4, 4));

	}
}
