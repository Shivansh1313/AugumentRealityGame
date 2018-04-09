using UnityEngine;

public class gunScript : MonoBehaviour {

	// Use this for initialization
	public float damage = 10f;
	public float range = 100f;
	public GameObject go;
	public Camera fpsCam;
	private float rotateSpeed = 50f;
	// Update is called once per frame
	public	void Update () {
		
		if (Input.GetButtonDown ("Firebtn")) {
		
			go.transform.Rotate (Vector3.up,rotateSpeed*Time.deltaTime );

			Shoot ();
		}
		go.transform.Rotate (Vector3.up,rotateSpeed*Time.deltaTime );


		}
	void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast (fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
			Debug.Log (hit.transform.name);
		
			Target target = hit.transform.GetComponent<Target>();
	
			if (target != null) {
			
				target.Takedamage (damage);
			}
		
		}
	
	}

}
