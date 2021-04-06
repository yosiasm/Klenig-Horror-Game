using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camrapermission : UniAndroidPermission {
	// Use this for initialization
	void Start () {
		if (!UniAndroidPermission.IsPermitted (AndroidPermission.CAMERA)) {
			RequestPermission ();
		}
	}
	public void RequestPermission()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.CAMERA, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}

	private void OnAllow()
	{
		// execute action that uses permitted function.
	}

	private void OnDeny()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.CAMERA, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}

	private void OnDenyAndNeverAskAgain()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.CAMERA, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}
}
