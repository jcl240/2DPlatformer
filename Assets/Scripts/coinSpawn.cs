using UnityEngine;
using System.Collections;

public class coinSpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		spawnCoin ();
	}

	public float spawnRate;
	public GameObject CoinPrefab;

    public float lastSpawnTime = 0;
	public ArrayList children = new ArrayList();

	void Awake() {
		foreach (Transform child in transform)
		{
			children.Add (child.gameObject);
		}
	}

	void Update() {
		if (lastSpawnTime + spawnRate*2 < Time.time && gameObject.GetComponent<hasCoin>().occupied == false) {
			spawnCoin ();
		}
	}

	void spawnCoin(){
		GameObject  ChildGameObject = transform.GetChild(Random.Range(0, transform.childCount)).gameObject;
		float spawnHeight = ChildGameObject.GetComponent<BoxCollider2D> ().bounds.size.y/2;
		if (ChildGameObject.name.Contains ("top") || ChildGameObject.name.Contains ("platform")) {
			Vector3 spawnPosition = ChildGameObject.transform.position;
			gameObject.GetComponent<hasCoin>().occupied = true;
			spawnPosition.y += spawnHeight+1;
			GameObject coin = Instantiate (CoinPrefab, spawnPosition, Quaternion.identity) as GameObject;
			coin.transform.parent = gameObject.transform;
		}
	}
}
