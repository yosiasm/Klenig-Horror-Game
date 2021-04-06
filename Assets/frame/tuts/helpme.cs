using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class helpme : MonoBehaviour,IPointerClickHandler {
	public List<Text> tex;
	public List<Image> img;
	Color c;
	void Start () {
			foreach (var item in tex) {
				item.CrossFadeAlpha(255,0.1f,false);
			}
			foreach (var item in img) {
				c = item.color;
				c.a = 1;
				item.color = c;
			}
		
	}
	public void OnPointerClick(PointerEventData eventData){
		foreach (var item in tex) {
			item.CrossFadeAlpha(255,0.1f,false);
		}
		foreach (var item in img) {
			c = item.color;
			c.a = 1;
			item.color = c;
		}
	}
	void Update () {
		foreach (var item in tex) {
			item.CrossFadeAlpha(0,1,false);
		}
		foreach (var item in img) {
			c = item.color;
			c.a = Mathf.Lerp(c.a,0,Time.deltaTime*0.4f);
			item.color = c;
		}
	}
}
