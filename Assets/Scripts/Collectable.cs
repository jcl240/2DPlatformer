using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	public void collect() {
		transform.parent.GetComponent<hasCoin> ().occupied = false;
		transform.parent.GetComponent<coinSpawn> ().lastSpawnTime = Time.time;
		Destroy (gameObject);
	}
	void FixedUpdate (){
		
	}
}
