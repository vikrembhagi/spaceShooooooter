using UnityEngine;
using System.Collections;

public class horizontalMovement : MonoBehaviour {

	// Use this for initialization
	public float speed;
	
	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody>().velocity = transform.right * speed;
	}
}
