using UnityEngine;
using System.Collections;

public class EthanLife : MonoBehaviour {
	public float moveSpeed = 3;
	public float rotateSpeed = 3;
	// Use this for initialization
	public float minMass, maxMass;
	Rigidbody r;
	void Start () {
		r = GetComponent<Rigidbody> ();
		r.mass = Random.Range (minMass, maxMass);	//为物体设置一个随机质量
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0))		//点击鼠标左键重新加载场景
			Application.LoadLevel("doll");

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(Vector3.right * Time.deltaTime * -moveSpeed);
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
		}

	}
}
