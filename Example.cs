using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Example : MonoBehaviour {

	public void Start()
	{
		var scheduler = new Scheduler();
		scheduler.Execute(() => RunInTheFuture(), 1000);
	}

	private void RunInTheFuture()
	{
		Debug.Log("This Ran 1000ms in the future");
	}
}
