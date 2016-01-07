using UnityEngine;
using System.Collections;

public class tankCamera : MonoBehaviour {

	public Transform target;

	// Update is called once per frame
	void LateUpdate () {
		transform.position = target.position;
	}
}
