using UnityEngine;
using System.Collections;

public class shell : MonoBehaviour {
	public GameObject explosionEffect;

	void OnCollisionEnter()
	{
		Instantiate (explosionEffect, transform.position, transform.rotation);
		Destroy (gameObject);
	}
}
