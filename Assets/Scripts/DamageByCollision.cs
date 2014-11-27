using UnityEngine;
using System.Collections;

public class DamageByCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){

		Debug.Log ("krashade in i planet med " + collider.name);
		GameObject player = GameObject.FindGameObjectWithTag (collider.tag);
		audio.Play ();
		Destroy (player);

	}
}
