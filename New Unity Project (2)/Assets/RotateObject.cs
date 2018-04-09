using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection.Emit;

public class RotateObject : MonoBehaviour {

	// Use this for initialization
	public GameObject objectRotate , or2, or3;
	private GameObject pos1;
	public float rotateSpeed = 50f;
	   bool rotateStatus = false;


	public void Rotasi()
	{
		if (rotateStatus == false) {
			rotateStatus = true;
		} else {
		
			rotateStatus = false;
		}
	//	Vector3 pos = new Vector3 ();
	
	}

	// Update is called once per frame
	void Update () {
		if (rotateStatus == true) {
			objectRotate.transform.Rotate (Vector3.up,rotateSpeed*Time.deltaTime );
			//or2.transform.Rotate (Vector3.up,rotateSpeed*Time.deltaTime );
			or2.transform.Rotate (Vector3.down,rotateSpeed*Time.deltaTime );
			//Destroy (or2);
			or3.transform.Rotate (Vector3.up,rotateSpeed*Time.deltaTime );


		}

	}
}
