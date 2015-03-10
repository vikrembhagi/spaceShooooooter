using UnityEngine;
using System.Collections;

public class boundary : MonoBehaviour {

	public Rigidbody rb1;

	// Use this for initialization
	void Start () {
	
		rb1 = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		Destroy(other.gameObject);
	}
}
