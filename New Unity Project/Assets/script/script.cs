using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	// Use this for initialization
	public string goodbyWorld = "Goodbye World";
	int number = 0;
	void Start () {		//这个对象一出现在场景就被Unity调用
		Debug.Log (goodbyWorld);
	}
	
	// Update is called once per frame
	void Update () {		//每一帧都会被调用
		Debug.Log (number);
		number = changeNum (number);
	
	}

	int changeNum(int Number)
	{
		Number += 1;
		return Number;
	}
}
