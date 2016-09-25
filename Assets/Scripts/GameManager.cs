using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public enum GameState{
		Playing, Ended
	}

	private static GameManager _instance;


	public Text punchesText;
	public GameObject winGameGraphics;
	public GameObject loseGameGraphics;

	public static GameState State = GameState.Playing;

	private int punches = 4;

	void Start(){
		_instance = this;
		_instance.punchesText.text = "4";
		winGameGraphics.SetActive(false);
		loseGameGraphics.SetActive(false);
	}

	public static void removePunch(){
		_instance.punches -= 1;
		_instance.punchesText.text = _instance.punches.ToString();
	}

	public static bool hasPunches(){
		return _instance.punches != 0;
	}

	public static void WinTheGame(){
		State = GameState.Ended;
		_instance.winGameGraphics.SetActive(true);
	}

	public static void LoseTheGame(){
		State = GameState.Ended;
		_instance.loseGameGraphics.SetActive(true);
	}
}
