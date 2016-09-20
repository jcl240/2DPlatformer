using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public float rotationSpeed;

	void OnTriggerEnter2D(Collider2D other){
		Destroy(gameObject);
	}

	void Update () {
		transform.rotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.up);
	}

}
