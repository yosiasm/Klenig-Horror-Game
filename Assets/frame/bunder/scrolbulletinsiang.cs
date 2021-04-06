using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolbulletinsiang : MonoBehaviour {

	public Transform target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target.localPosition.x >-215 && target.localPosition.x <615) {
			//transform.localScale = Vector3.Lerp(transform.localScale, new Vector3 (0.15f,0.15f,0.15f),Time.deltaTime*3);
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3(transform.localPosition.x,20), Time.deltaTime * 3);
		}else
			//transform.localScale = Vector3.Lerp(transform.localScale, new Vector3 (0.08f,0.08f,0.08f),Time.deltaTime*3);
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3(transform.localPosition.x,0), Time.deltaTime * 3);
	}
}
