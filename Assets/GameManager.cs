using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private bool gameEnded = false;

	public GameObject GameOver;

	private int pathIndex = 0;

	
	// Update is called once per frame
	void Update () {
		if (gameEnded)
			return;

		if (pathIndex >= Path1.points.Length - 1)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		gameEnded = true;
		GameOver.SetActive (true);
	}
}
