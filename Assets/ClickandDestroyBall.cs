using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDestroyBall : MonoBehaviour {

	/*public GUIText scoreText;
	private int score;
	public int scoreValue;

	void Start () {

		score = 0;
		UpdateScore ();
	}*/

	void Update () {
		if (Input.GetKeyDown (KeyCode.R))
			Application.LoadLevel (0);
	}

	void OnMouseDown ()
	{
		Destroy (gameObject);
		//AddScore (scoreValue);
	}

	/*public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}*/
}