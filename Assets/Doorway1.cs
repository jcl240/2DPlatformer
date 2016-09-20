using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Doorway1 : MonoBehaviour {
	
	public GameObject player;
	private float doorX = transform.position.x;
	private float doorY = transform.position.y;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void UseDoor() {

		float moveVertical = Input.GetAxis ("Vertical");
		float playerX = player.transform.position.x;
		float playerY = player.transform.position.y;
		if(moveVertical == 1 && ((playerX > doorX - 1)||(playerX < doorX + 1)) &&
			((playerY > doorY - 1)||(playerY < doorY + 1)){
				SceneManager.LoadScene (1);
			}

	}

}
