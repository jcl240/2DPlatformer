using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	public GameObject player;
	public SimplePlatformController playerController;
	public GameObject gameCamera;
	Vector3 cameraRotation;
	public Vector3 playerPosition;
	public Vector3 cameraPosition;
	public LayerMask frontMask;
	public LayerMask backMask;

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
		if (player.GetComponent<SimplePlatformController>().getPage() == "frontPage") {
			gameCamera.GetComponent<Camera> ().cullingMask = frontMask;
			player.GetComponent<SimplePlatformController> ().changePage ();
		}
		else{
			gameCamera.GetComponent<Camera> ().cullingMask = backMask;
			player.GetComponent<SimplePlatformController> ().changePage ();
		}
		foreach (Transform child in player.transform)
			child.gameObject.layer = player.layer;
		gameCamera.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z * -1);
		gameCamera.transform.Rotate (0, 180, 0);
		player.transform.position =  new Vector3(playerPosition.x, playerPosition.y, playerPosition.z * -1);
		player.transform.Rotate (0, 180, 0);
	}

}
