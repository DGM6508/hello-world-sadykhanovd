using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement4 : MonoBehaviour {

	public float speed = 7f;

	public GameObject GameOver;

	private Transform target;
	private int pathIndex = 0;

	void Start () {
		target = Path4.points [pathIndex];
	}

	void Update () {

		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 0.5f)
		{
			GetNextPoint();
		}
	}

	void GetNextPoint() {

		if (pathIndex >= Path4.points.Length)
		{
			GameOver.SetActive (true);
			Destroy (gameObject);
			return;
		}

		pathIndex++;
		target = Path4.points [pathIndex];
	}
}