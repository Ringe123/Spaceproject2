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
	


		if (currentHealth <= 0f) {

			Die();

			}

	}

	void Die(){

		Destroy (this.gameObject);

	}

	void OnTriggerEnter2D (Collider2D collider){

		//GameObject hitObject = GameObject.Find (collider.name);
		switch (collider.name) {

				case "LaserShot(Clone)": 
					currentHealth -= 5f;
			break;

				case "Rocket":
					currentHealth -= 20f;
			break;


			default:
			break;
			}


	}
}
