using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class syain : MonoBehaviour {

	ShineEffector sa;
	public GameObject aku;
	void Start () {
		sa = aku.AddComponent<ShineEffector> ();
		sa.width = 0.01f;
		StartCoroutine (suep ());
	}
	public bool kilat;
	IEnumerator suep(){
		while (true) {
			yield return new WaitForSeconds (Random.Range(4,10));
			kilat = kilat ? false : true;
		}
	}
	// Update is called once per frame
	void Update () {
		if (kilat) {
			sa.YOffset = Mathf.Lerp (sa.yOffset, 1, Time.deltaTime);
		} else {
			sa.YOffset = -1;
		}
	}
}
