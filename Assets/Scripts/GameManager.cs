﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public enum GameState{
		Playing, Ended
	}

	private static GameManager _instance;
	public static float deathHeight;

	GameObject punchObject;
	public Text punchesText;
	GameObject loseGameGraphics;

	public static GameState State = GameState.Playing;

	public int punches;

	void Awake(){
		State = GameState.Playing;
		deathHeight = gameObject.transform.localPosition.y;
		_instance = this;
		_instance.punchObject = GameObject.Find ("/Canvas/number");
		if (_instance.punchObject != null) {
			_instance.punchesText = _instance.punchObject.GetComponent<Text> ();
			_instance.punchesText.text = punches.ToString ();
		}
		_instance.loseGameGraphics = GameObject.Find ("/Canvas/LoseGraphics");
		if (_instance.loseGameGraphics != null)
			_instance.loseGameGraphics.SetActive(false);
	}

	void Start(){
	}

	public void removePunch(){
		_instance.punches -= 1;
		_instance.punchesText.text = _instance.punches.ToString();
	}

	public static bool hasPunches(){
		return _instance.punches != 0;
	}

	public void LoseTheGame(){
		State = GameState.Ended;
		_instance.loseGameGraphics.SetActive(true);
	}
}
