using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;

public class Target : MonoBehaviour {

	// Use this for initialization
	public float health = 50f;
	//public GameObject o1;
	public void Takedamage (float amount)
	{
		health -= amount;
		if (health <= 0) {
			die ();
		}
	}

	void die()
	{
	
		Destroy (gameObject);
	}

}
