using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ikutcolorgrading : MonoBehaviour {

	public coloran co;
	public List<Image> img;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Image item in img) {
			item.color = Color.Lerp (item.color, co.getcolor (), Time.deltaTime * 0.2f);
		}
	}
}
