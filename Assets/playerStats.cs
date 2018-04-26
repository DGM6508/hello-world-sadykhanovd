using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour {

	public static int Lives;
	public int startLives = 10;

	// Use this for initialization
	void Start () {

		Lives = startLives;
	}
}
