using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	[SerializeField] private float coolTime;
	private float time = 0f;
	[SerializeField] private SeedManager seedController;

	private void Update ()
	{
		time += Time.deltaTime;

		if (Input.GetMouseButton (0) && time > coolTime) {
			seedController.onFire ();
			time = 0f;
		}
	}

}
