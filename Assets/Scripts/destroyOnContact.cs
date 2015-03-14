using UnityEngine;
using System.Collections;

public class destroyOnContact : MonoBehaviour {

	// Use this for initialization
	public GameObject explosion;
	public GameObject explosion1;
	public float HitCount;
	private float count;


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
		{
			return;
		} 

		else 	
		{
			//count=count+1;
			Destroy (other.gameObject);
			//GetComponent<Rigidbody>().Collider.isTrigger="false";
			//if(count>=HitCount){
			Instantiate(explosion, GetComponent<Rigidbody>().transform.position, GetComponent<Rigidbody>().transform.rotation);
			Destroy (gameObject);

			if(other.tag == "Player")
			{
			Instantiate(explosion1, other.gameObject.GetComponent<Rigidbody>().transform.position, other.gameObject.GetComponent<Rigidbody>().transform.rotation);
			Destroy (other.gameObject);
//			yield WaitForSeconds (0.25);
			
			//count=0;
			}
		}
	}
}
