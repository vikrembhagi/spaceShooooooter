using UnityEngine;
using System.Collections;





[System.Serializable]

public class Boundary{

	public float xMax, xMin, zMax, zMin;
}


public class playerController : MonoBehaviour {

	public Rigidbody rb1;
	public Boundary boundary;
	public float tilt;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float nextFire=0;
	public float shipSpeed;


	// Use this for initialization
	void Start () {
	
		rb1 = GetComponent<Rigidbody>();
	}


	void Update(){

		if (Input.GetButton ("Fire1") && Time.time > nextFire) {

			nextFire=Time.time + fireRate;
			Instantiate(shot,shotSpawn.position,shotSpawn.rotation);
		
		}



	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontal,0.0f, vertical);

		rb1.velocity = movement * shipSpeed;

		rb1.position = new Vector3 (

			Mathf.Clamp (rb1.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp (rb1.position.z, boundary.zMin, boundary.zMax)
	
			);

		rb1.rotation = Quaternion.Euler (0.0f,0.0f, rb1.velocity.x * -tilt);




}
}
