using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject enemy1;
	public GameObject enemy2;
	public float enemy1Count;
	public float enemy2Count;
	public float spawnInterval;
	public float spawnInterval2;
	public float waveNumbers;
	public Vector3 spawnPositionTop;
	public Vector3 spawnPositionSide;
	public float waveInterval;


	// Use this for initialization
	void Start () {

		StartCoroutine(spawnEnimies ());
		StartCoroutine(spawnEnimiesSide ());
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
				Vector3 spawnValues = new Vector3 (Random.Range (-spawnPositionTop.x, spawnPositionTop.x), spawnPositionTop.y, spawnPositionTop.z);
				Instantiate (enemy1, spawnValues, Quaternion.identity);
				yield return new WaitForSeconds (spawnInterval);
			}

			yield return new WaitForSeconds(waveInterval);
		}

	}


	IEnumerator spawnEnimiesSide () {
		
		while (true) {

			for (int i= 0; i<enemy2Count; i++) {
				Vector3 spawnValues1 = new Vector3 (spawnPositionSide.x, spawnPositionSide.y, Random.Range (-spawnPositionSide.z, spawnPositionSide.z));
				Instantiate (enemy2, spawnValues1, Quaternion.identity);
				yield return new WaitForSeconds (spawnInterval2);
			}
			
			yield return new WaitForSeconds(waveInterval);
		}
		
	}




}
