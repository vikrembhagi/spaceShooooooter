using UnityEngine;
using System.Collections;

public class asteroidRotation : MonoBehaviour {

	public Rigidbody rb;
	public float tumble;
	// Use this for initialization

	// Update is called once per frame

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
