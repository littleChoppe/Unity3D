using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	public float moveSpeed;
//	public AudioSource audio;
	Rigidbody r;

	void Start () {
		r = GetComponent<Rigidbody> ();
//		audio = GetComponent<AudioSource> ();
	}

	void Update () {

		if (r.IsSleeping ()) {
			Application.LoadLevel(0);
		}
		//按“←”时向左移动
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * -moveSpeed);
		}

		//按“→”时向右移动
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * moveSpeed);
		}
	
	}

//	void OnCollisionEnter(Collision e)
//	{
//		if (e.gameObject == TreeInstance)
//			audio.Play();
//
//	}
	
}
