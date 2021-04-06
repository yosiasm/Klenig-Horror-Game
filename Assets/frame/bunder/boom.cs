using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class boom : MonoBehaviour,IPointerClickHandler {

	public int color;
	public disco co;
	public futar a;
	public futar b;
	public futar c;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPointerClick(PointerEventData eventData){
		co.kchaww = true;
		co.setcolor (color);
		a.cw = a.cw ? false : true;
		b.cw = b.cw ? false : true;
		c.cw = c.cw ? false : true;

	}
}
