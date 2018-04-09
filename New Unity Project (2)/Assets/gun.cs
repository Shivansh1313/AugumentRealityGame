using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Experimental.UIElements;

public class gun : MonoBehaviour {

	public GameObject bulletPrefab;


	public void  Update()
	{
		float  x = CrossPlatformInputManager.GetAxis ("Horizontal1");
		float y = CrossPlatformInputManager.GetAxis ("Vertical1");
		//float y1 = CrossPlatformInputManager.GetButtonDown ("Vertical1");
		//float x1 = CrossPlatformInputManager.GetButtonDown ("Horizontal1");
		//string b = (string)btn.ToString (); 
		//bool x1 = Input.GetButtonDown ();
	



		if (Input.GetMouseButtonDown (0) ) {
		
			GameObject go = Instantiate (bulletPrefab, transform.position, transform.rotation) as GameObject;
			go.GetComponent <Rigidbody>().AddForce (transform.forward*100,ForceMode.Impulse);


		}

	}
}  
