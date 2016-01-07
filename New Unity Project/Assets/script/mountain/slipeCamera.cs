using UnityEngine;
using System.Collections;

public class slipeCamera : MonoBehaviour {

	public Transform target;

	void LateUpdate () {
		transform.position = target.position;	//摄像机跟随滑板
	
	}
}
