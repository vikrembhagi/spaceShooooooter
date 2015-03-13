using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject enemy1;
	public float enemy1Count;
	public float spawnInterval;
	public float waveNumbers;
	public Vector3 spawnPosition;
	public float waveInterval;


	// Use this for initialization
	void Start () {

		StartCoroutine(spawnEnimies ());
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Return)) {  
			Application.LoadLevel ("Level1");  
		}  

	}
	
	// Update is called once per frame
	IEnumerator spawnEnimies () {
	

		while (true) {
			for (int i= 0; i<enemy1Count; i++) {

				Vector3 spawnValues = new Vector3 (Random.Range (-spawnPosition.x, spawnPosition.x), spawnPosition.y, spawnPosition.z);
				Instantiate (enemy1, spawnValues, Quaternion.identity);
				yield return new WaitForSeconds (spawnInterval);

			}

			yield return new WaitForSeconds(waveInterval);
		}

	}
}
