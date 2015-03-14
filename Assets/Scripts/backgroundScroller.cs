using UnityEngine;
using System.Collections;

public class backgroundScroller : MonoBehaviour {

	public float tileSize;
	public float scrollSpeed;
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {

		startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tileSize);
		transform.position = startPosition + Vector3.forward * newPosition;
	}
}
