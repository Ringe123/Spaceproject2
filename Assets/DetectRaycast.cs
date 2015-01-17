using UnityEngine;
using System.Collections;

public class DetectRaycast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D hit = Physics2D.Raycast (transform.position, Vector2.up);

		if (hit.collider != null) {

			Debug.Log ("ser " + collider.name);


				}
	
	}
}
