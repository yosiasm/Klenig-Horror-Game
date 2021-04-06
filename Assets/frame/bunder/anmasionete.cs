using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anmasionete : MonoBehaviour {

	public Transform chy;
	public Transform a1;
	public Transform a2;
	public Transform a3;
	public Transform a4;
	public Transform a5;
	public Transform d1;
	public Transform d2;
	public Transform d3;
	public Transform d4;
	public Transform d5;
	public Transform d6;
	void Start () {
		
	}
	
	// Update is called once per frame
	bool w=true;
	void Update () {
		if (chy.localScale.x<5) {
			a1.localScale = Vector3.Lerp (a1.localScale, new Vector3(2.71f,2.71f),Time.deltaTime*5);
			if (a1.localScale.x>1) {
				a2.localScale = Vector3.Lerp (a2.localScale, new Vector3(2.71f,2.71f),Time.deltaTime*3);
				if (a2.localScale.x>1) {
					a3.localScale = Vector3.Lerp (a3.localScale, new Vector3(2.71f,2.71f),Time.deltaTime*3);
					if (a3.localScale.x>1) {
						a4.localScale = Vector3.Lerp (a4.localScale, new Vector3(2.71f,2.71f),Time.deltaTime*3);
						if (a4.localScale.x>1 && a5!=null) {
							if (a5.localScale.x>3f) {
								w = false;
							}

							if (false) {
								a5.localScale = Vector3.Lerp (a5.localScale, new Vector3 (4, 4), Time.deltaTime * 3);
							}else{
								a5.localScale = Vector3.Lerp (a5.localScale, new Vector3 (2.71f, 2.71f), Time.deltaTime * 3);
							}

							if (a5.localScale.x>1.5f ) {
								d1.localScale = Vector3.Lerp (d1.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);
								if (d1.localScale.x>0.1f) {
									d2.localScale = Vector3.Lerp (d2.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);
									if (d2.localScale.x>0.1f) {
										d3.localScale = Vector3.Lerp (d3.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);
										if (d3.localScale.x>0.1f) {
											d4.localScale = Vector3.Lerp (d4.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);
											if (d4.localScale.x>0.1f) {
												d5.localScale = Vector3.Lerp (d5.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);
												if (d5.localScale.x>0.1f && d6!=null) {
													d6.localScale = Vector3.Lerp (d6.localScale, new Vector3(0.21f,0.21f),Time.deltaTime*3);

												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
