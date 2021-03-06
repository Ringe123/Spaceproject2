﻿using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float maxSpeed = 5f;
	public float damage = 10f;


	void Update () {
	
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;
		transform.position = pos;

	}
}
