using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public int maxHealth = 100;
	public int currentHealth = 100;
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

	public int getCurrentHP(){

		return currentHealth;

	}

	void OnTriggerEnter2D (Collider2D collider){

		//GameObject hitObject = GameObject.Find (collider.name);
		//TODO: ta bort switchsats
		switch (collider.name) {

				case "LaserShot(Clone)": 
				currentHealth -= collider.gameObject.GetComponent<BulletMovement>().damage;;
			break;
				case "LaserShot2(Clone)": 
				
				currentHealth -= collider.gameObject.GetComponent<BulletMovement>().damage;
			break;

				case "Rocket":
					currentHealth -= 20;
			break;


			default:
			break;
			}


	}
}
