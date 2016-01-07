using UnityEngine;
using System.Collections;

public class tank : MonoBehaviour {

	public float moveSpeed;
	public float rotateSpeed;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);
		}
	
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);
		}
	}
}
