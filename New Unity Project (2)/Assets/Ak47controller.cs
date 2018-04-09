using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Ak47controller : MonoBehaviour {

	private Rigidbody rb;
	private Animation anim;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim=GetComponent<Animation> ();	
	}

	// Update is called once per frame

	void Update () {
		float  x = CrossPlatformInputManager.GetAxis ("Horizontal1");
		float y = CrossPlatformInputManager.GetAxis ("Vertical1");

		float x1 = CrossPlatformInputManager.GetAxis ("Vertical");
		float y1 = CrossPlatformInputManager.GetAxis ("Horizontal");

		Vector3 movement = new Vector3 (x,0,y);
		Vector3 mov =new Vector3 (x1,0,y1);
		rb.velocity = movement*4f; 
		if(x !=0 && y !=0)
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg , transform.eulerAngles.z);

		}
	
		/*if (x1 != 0 && y1 != 0) 
		{
	
			rotate.eulerAngles = new Vector4 (rotate.eulerAngles.x, Mathf.Atan2(x1,y1) * Mathf.Rad2Deg , rotate.eulerAngles.z);
		}*/

	}
}
