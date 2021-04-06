using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class aksicer : MonoBehaviour {

	public Button butt;
	void Start () {
		butt.onClick.AddListener (onbuttdown);
	}
	void onbuttdown(){
		if ( GameObject.Find ("cermin").transform.localPosition.y >=0 || show==1) {
			show = 3;
		}else if (GameObject.Find ("cermin").transform.localPosition.y <=-499 ||show ==3) {
			show = 1;
		}
	}
	
	int show=3;
	void Update () {
		if (show ==1) {
			GameObject.Find ("cermin").transform.localPosition = Vector3.Lerp (GameObject.Find ("cermin").transform.localPosition, new Vector3 (0, 5, 0), 3f * Time.deltaTime);	
			if (GameObject.Find ("cermin").transform.localPosition.y >=0) {
				show = 2;
			}

		} else if (show == 3) {
			GameObject.Find ("cermin").transform.localPosition = Vector3.Lerp (GameObject.Find ("cermin").transform.localPosition, new Vector3 (0, -499, 0), 3f * Time.deltaTime);	
			if (GameObject.Find ("cermin").transform.localPosition.y <=-499) {
				show = 2;
			}
		}

	}
}
