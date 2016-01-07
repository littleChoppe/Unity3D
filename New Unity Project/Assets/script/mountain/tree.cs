using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {

	public AudioSource audiosource;
	// Use this for initialization
	void Start () {
		audiosource = GetComponent<AudioSource> ();
	}
	
	void OnCollisionEnter()
	{
		audiosource.Play();

		Application.LoadLevel (0);
	}
}
