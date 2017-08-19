using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {
	public GameObject housePrefeb;

	// Use this for initialization
	void Start () {
//		GameObject myCube = GameObject.CreatePrimitive (PrimitiveType.Cube);
//		myCube.transform.position = new Vector3 (1,2,3);
//		myCube.transform.localEulerAngles = new Vector3 (2,2,2);
//		myCube.transform.localScale = new Vector3 (3,3,3);

		for (int i = 0; i < 10; i++) {
			GameObject myHouse = GameObject.Instantiate (housePrefeb);
			myHouse.transform.position = new Vector3 (1+i*15,1,1);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
