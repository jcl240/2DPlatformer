using UnityEngine;
using System.Collections;

public class holePuncher : MonoBehaviour {

	public GameObject hole;
	public Camera camera;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && GameManager.hasPunches())
			punchHole ();
	}

	void punchHole(){
		Vector3 worldCoordinates = camera.ScreenToWorldPoint (Input.mousePosition);
		worldCoordinates.z = 0;
		Instantiate (hole, worldCoordinates, Quaternion.identity);
		GameManager.removePunch ();
	}
}
