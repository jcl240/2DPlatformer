using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	public GameObject player;
	private float doorX;
	private float doorY;

	// Use this for initialization
	void Start () {

		doorX = gameObject.transform.position.x;
		doorY = gameObject.transform.position.y;
	
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis ("Vertical");
	
	}



	public void UseDoor(float moveVertical) {

		float playerX = player.transform.position.x;
		float playerY = player.transform.position.y;
		if (moveVertical == 1 && ((playerX > doorX - 1) || (playerX < doorX + 1)) &&
		   ((playerY > doorY - 1) || (playerY < doorY + 1))) {
		}
				


	}

}
