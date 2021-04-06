using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gantiskin : MonoBehaviour {

	public List<Sprite> sprite1;
	public SpriteRenderer spriteRenderer;
	public bool gantikah;
	void Start () {
		//spriteRenderer = GetComponent<Image> ();
		//if (spriteRenderer.sprite==null) {
		//	spriteRenderer.sprite = sprite1;
		//}
	}
	
	// Update is called once per frame
	void Update () {
		if (gantikah) {
			spriteRenderer.sprite = sprite1 [Random.Range (0, sprite1.Count)];
			gantikah = false;
		}
	}
}
