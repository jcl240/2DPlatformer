using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	public GameObject player;
	public SimplePlatformController playerController;
	public GameObject gameCamera;
	Vector3 cameraRotation;
	public float sign = 1;
	public Vector3 playerPosition;
	public Vector3 cameraPosition;

	// Use this for initialization
	void Start () {
		playerController = player.GetComponent<SimplePlatformController> (); //get the player controller
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<BoxCollider2D>().IsTouching(player.GetComponent<BoxCollider2D>()) && Input.GetKeyDown(KeyCode.E)) {
			UseDoor ();
		}
	}

	public void UseDoor() {
		Vector3 playerPosition = player.transform.position;
		Vector3 cameraPosition = gameCamera.transform.position;
		if (player.layer == 14) {
			player.layer = 15;
		}
		else
			player.layer = 14;
		gameCamera.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z * -1);
		gameCamera.transform.Rotate (0, 180, 0);
		player.transform.position =  new Vector3(playerPosition.x, playerPosition.y, playerPosition.z * -1);
		player.transform.Rotate (0, 180, 0);
	}

}
