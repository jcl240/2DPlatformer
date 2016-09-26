using UnityEngine;
using System.Collections;

public class holePuncher : MonoBehaviour {

	public GameObject hole;
	public Camera cam;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && GameManager.hasPunches())
			punchHole ();
	}

	void punchHole(){
		if (GameManager.State == GameManager.GameState.Playing) {
			Vector3 worldCoordinates = cam.ScreenToWorldPoint (Input.mousePosition);
			worldCoordinates.z = 0;
			Instantiate (hole, worldCoordinates, Quaternion.identity);
			GameObject.Find ("GameManager").GetComponent<GameManager> ().removePunch ();
		}
	}
}
