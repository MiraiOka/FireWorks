using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedController : MonoBehaviour {

	[SerializeField] private GameObject seed;
	[SerializeField] private float coolTime;
	private float time = 0;
	[SerializeField] AudioClip audioClip;
	private AudioSource audio;

	private void Start()
	{
		audio = GetComponent<AudioSource> ();
	}

	void Update () {
		time += Time.deltaTime;
		if (Input.GetMouseButton (0) && time > coolTime) {
			Vector3 clickPosition = Input.mousePosition;
			print (Camera.main.ScreenToViewportPoint (clickPosition) + new Vector3 (0, 0, 40));
			GameObject fire = Instantiate (seed, new Vector3(Camera.main.ScreenToViewportPoint(clickPosition).x * 55 - 27, 0, 40), Quaternion.Euler(-90, 0, 0));
			Destroy (fire, 5);
			time = 0;
			Invoke ("onAudio", 3.0f);
		}
	}

	void onAudio()
	{
		audio.PlayOneShot (audioClip);
	}
}
