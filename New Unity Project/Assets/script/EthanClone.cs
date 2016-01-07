using UnityEngine;
using System.Collections;

public class EthanClone : MonoBehaviour {
	public GameObject Ethan;
	public Transform t;

	void Update () {
		if (Input.GetMouseButtonDown (1))
			Instantiate (Ethan, t.position, t.rotation);	//鼠标按右键时创建一个Ethan对象
	
	}
}
