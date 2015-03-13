using UnityEngine;
using System.Collections;

public class destroyOnContact : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion;
	public float HitCount;
	private float count;


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary") {
		
			return;
		} else {

			count=count+1;

			Destroy (other.gameObject);
			//GetComponent<Rigidbody>().Collider.isTrigger="false";

			if(count>=HitCount){

			Instantiate(explosion, GetComponent<Rigidbody>().transform.position, GetComponent<Rigidbody>().transform.rotation);
			
				Instantiate(explosion, other.gameObject.GetComponent<Rigidbody>().transform.position, other.gameObject.GetComponent<Rigidbody>().transform.rotation);
			Destroy (other.gameObject);
			Destroy (gameObject);
				count=0;

				if(other.tag=="Player"){

					Application.LoadLevel ("Level1");


				}
			}
		}


	}
}
