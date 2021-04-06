using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationpermission : UniAndroidPermission {

	void Start () {
		if (!UniAndroidPermission.IsPermitted (AndroidPermission.ACCESS_FINE_LOCATION)) {
			RequestPermission ();
		}
	}
	public void RequestPermission()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.ACCESS_FINE_LOCATION, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}

	private void OnAllow()
	{
		// execute action that uses permitted function.
	}

	private void OnDeny()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.ACCESS_FINE_LOCATION, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}

	private void OnDenyAndNeverAskAgain()
	{
		UniAndroidPermission.RequestPermission(AndroidPermission.ACCESS_FINE_LOCATION, OnAllow, OnDeny, OnDenyAndNeverAskAgain);
	}
}
