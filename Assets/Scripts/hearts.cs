﻿using UnityEngine;
using System.Collections;

public class hearts : MonoBehaviour {

	public Texture tex;
	static float lives = 3;

	private float texWidth;
	private float texHeight;

	void Start() {
		texWidth = tex.width;
		texHeight = tex.height;
	}

	void OnGUI() {
		if (lives > 0) {
			Rect posRect = new Rect(80,50,texWidth / 5 * lives, texHeight);
			Rect texRect = new Rect(0,0,1.0f / 5 * lives, 1.0f);
			GUI.DrawTextureWithTexCoords(posRect, tex, texRect);
		}
	}

	public static void removeLife(){
		lives -= 1;
	}
}