﻿using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour {

	public Text livesText;


	// Update is called once per frame
	void Update () {
		livesText.text = playerStats.Lives.ToString () + " LIVES";
	}
}
