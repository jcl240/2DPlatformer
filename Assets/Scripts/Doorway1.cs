using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	//public GameObject player;
	SimplePlatformController player;
	public GameObject gameCamera;
	private float doorX;
	private float doorY;
	float cameraRotation;

	// Use this for initialization
	void Start () {
		player = GetComponent<SimplePlatformController> (); //get the player controller
		doorX = gameObject.transform.position.x;
		doorY = gameObject.transform.position.y;
	
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis ("Vertical");
		float playerX = player.transform.position.x;
		float playerY = player.transform.position.y;
		if (moveVertical == 1 && ((playerX > doorX - 1) || (playerX < doorX + 1)) &&
			((playerY > doorY - 1) || (playerY < doorY + 1))) {
		}
	}



	public void UseDoor(float moveVertical) {

		player.transform.position = -Vector3.forward;
		gameCamera.transform.position = -Vector3.forward;
		cameraRotation = gameCamera.transform.rotation.z;
		gameCamera.transform.position.z = cameraRotation + 180;
		//gameCamera.transform.rotation = Quaternion.AngleAxis (rotation, Vector3.forward);


	}

}
