using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedManager : MonoBehaviour {

	[SerializeField] GameObject seed;
	[SerializeField] AudioClip audioClip;
	private AudioSource audio;

	private void Start()
	{
		audio = GetComponent<AudioSource> ();
	}

	public void onFire()
	{
		Vector3 clickPosition = Input.mousePosition;
		GameObject fire = Instantiate (seed, new Vector3(Camera.main.ScreenToViewportPoint(clickPosition).x * 55 - 27, 0, 40), Quaternion.Euler(-90, 0, 0));
		fire.transform.parent = transform;
		Destroy (fire, 5);
		Invoke ("OnAudio", 3.0f);
	}

	private void OnAudio()
	{
		audio.PlayOneShot (audioClip);
	}


}
