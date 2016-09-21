using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	public GameObject player;
	public SimplePlatformController playerController;
	public GameObject gameCamera;
	Vector3 cameraRotation;

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
		if (player.layer == 14) {
			player.layer = 15;
		}
		else
			player.layer = 14;
		player.transform.Translate (Vector3.forward*2);
		player.transform.Rotate (0, 180, 0);
		gameCamera.transform.Translate (Vector3.forward*15);
		gameCamera.transform.Rotate (0, 180, 0);


	}

}
