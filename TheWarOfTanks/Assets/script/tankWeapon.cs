using UnityEngine;
using System.Collections;

public class tankWeapon : MonoBehaviour {

	public GameObject shell;	//生成炮弹
	public float shootPower;	//炮弹发射的力
	public Transform shootPoint; //炮弹发射的位置

	private AudioSource audioSorce;

	void Start()
	{
		audioSorce = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//按下空格键发炮
		if (Input.GetKeyDown (KeyCode.Space))
			shoot ();

	}

	void shoot()
	{
		GameObject newShell = Instantiate (shell, shootPoint.position, shootPoint.rotation) as GameObject;
		Rigidbody r = newShell.GetComponent<Rigidbody> ();
		r.velocity = shootPoint.forward * shootPower;
		audioSorce.Play ();
	}
}
