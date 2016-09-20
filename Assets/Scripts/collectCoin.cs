using UnityEngine;
using System.Collections;

public class collectCoin : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Collectable")){
			Collectable collectable = other.GetComponent<Collectable>();
			collectable.collect();
		}
	}
}
