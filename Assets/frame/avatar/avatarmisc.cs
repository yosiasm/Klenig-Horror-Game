using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avatarmisc : MonoBehaviour {
	public Transform panel;
	public bool naik;
	public tompon pon;
	public tomcard card;
	void Start () {
		panel.localPosition = Vector3.down*1500;
	}

	// Update is called once per frame
	void Update () {
		if (pon.mulai || card.mulai) {
			panel.localPosition = Vector3.Lerp (panel.localPosition, Vector3.up*250, Time.deltaTime * 2);
		}else if (naik) {
			panel.localPosition = Vector3.Lerp (panel.localPosition, Vector3.zero, Time.deltaTime * 5);
		} else {
			panel.localPosition = Vector3.Lerp (panel.localPosition, Vector3.down*1500, Time.deltaTime * 5);
		}
	}

}
