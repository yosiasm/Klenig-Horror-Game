using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow : MonoBehaviour {
	[SerializeField]
	private Transform target;
	public float speed=100f;

	public float offsetChange;

	[SerializeField]
	private Vector3 offsetPosition;

	[SerializeField]
	private Space offsetPositionSpace = Space.Self;

	[SerializeField]
	private bool lookAt = true;


	void Start()
	{
		
	}

	private void Update()
	{
		//float a = target.position; 
		Refresh();
	}

	public void Refresh()
	{
		if(target == null)
		{
			Debug.LogWarning("Missing target ref !", this);

			return;
		}

		// compute position
		if(offsetPositionSpace == Space.Self)
		{
			Transform a = transform;
			//transform.position = Vector3.Slerp(a.position, target.position + offsetPosition,30000);
			transform.position = Vector3.MoveTowards(transform.position, target.position,  speed);
			if (transform.position.x < -offsetChange) {
				transform.position = target.position + offsetPosition;
			}
			if (transform.position.x > Screen.width + offsetChange) {
				transform.position = target.position + offsetPosition;
			}
			//Debug.Log (transform.position.x);
			//Debug.Log (Screen.width);


		}
		else
		{
			Transform a = transform;
			transform.position = Vector3.Lerp(a.position, target.position + offsetPosition,30);
			Debug.Log ("ok");
			//transform.position = target.position + offsetPosition;
		}

		// compute rotation
		if(lookAt)
		{
			transform.LookAt(target);
		}
		else
		{
			transform.rotation = target.rotation;
		}
	}
}
