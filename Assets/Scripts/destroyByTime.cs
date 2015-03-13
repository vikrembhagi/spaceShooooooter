using UnityEngine;
using System.Collections;

public class destroyByTime : MonoBehaviour {

	public float destroyTime=5;

	// Use this for initialization
	void Start () {
	
		Destroy(gameObject, destroyTime);
	}
}
