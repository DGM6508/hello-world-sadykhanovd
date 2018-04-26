using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {

	public float speed = 7f;

	public GameObject GameOver;

	private Transform target;
	private int path2Index = 0;

	void Start () {
		target = Path2.points [0];
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

		if (path2Index >= Path2.points.Length)
		{
			GameOver.SetActive(true);
			Destroy (gameObject);
			return;
		}

		path2Index++;
		target = Path2.points[path2Index];
	}
}