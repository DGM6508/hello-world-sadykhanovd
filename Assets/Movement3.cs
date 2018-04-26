using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour {

	public float speed = 7f;

	public GameObject GameOver;

	private Transform target;
	private int path4Index = 0;

	void Start () {
		target = Path4.points [0];
	}

	void Update () {

		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 2f)
		{
			GetNextPoint();
		}
	}

	void GetNextPoint() {

		if (path4Index >= Path4.points.Length)
		{
			GameOver.SetActive(true);
			Destroy (gameObject);
			return;
		}

		path4Index++;
		target = Path4.points[path4Index];
	}
}