using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public float maxHealth = 100f;
	public float currentHealth = 100f;
	GameObject player;


	// Use this for initialization
	void Start () {
	
		player  = GameObject.FindGameObjectWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
	
		if (maxHealth <= 0) {

			Die();

			}

	}

	void Die(){

		Destroy (player);

	}
}
