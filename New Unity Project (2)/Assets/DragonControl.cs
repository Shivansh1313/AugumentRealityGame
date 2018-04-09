using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class DragonControl : MonoBehaviour {
	
	private Rigidbody rb;
	private Animation anim;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		anim=GetComponent<Animation> ();	
	}

	// Update is called once per frame


	void Update () {
		float  x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");
		float z1 = CrossPlatformInputManager.GetAxis ("Vertical1");
		Vector4 movement = new Vector4 (x,z1,y);

		rb.velocity = movement*4f; 
		if(x !=0 && y !=0)
		{
			transform.eulerAngles = new Vector4 (transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg , transform.eulerAngles.z);
		}
		if (x != 0 || y != 0) {
			anim.Play ("walk");
		} 
		else if (z1 > 0) {
			anim.Play ("fly");
		}

		else

		{
			anim.Play("idle");
		}
	}
}
