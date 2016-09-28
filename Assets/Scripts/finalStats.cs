using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class finalStats : MonoBehaviour {

	public Text coinsCollected;
	public Text livesLeft;
	public Text timePlayed;

	// Use this for initialization
	void Start () {
		coinsCollected.text += GameManager.getPoints ().ToString();
		livesLeft.text += hearts.lives.ToString ();
		timePlayed.text += GameManager.timeStarted - Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
