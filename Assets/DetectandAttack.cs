using UnityEngine;
using System.Collections;

public class DetectandAttack : MonoBehaviour {

	GameObject player; 
	public GameObject bulletPrefab;
	bool detectedPlayer = false;
	public float firedelay = 0.25f;
	float cooldownTimer = 0;
	public Vector3 bulletOffset = new Vector3(0,0.5f ,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (detectedPlayer == true) {
			DoAttack();
				}
	
	}

	void OnTriggerEnter2D(Collider2D collider){

		if (collider.tag == "Player") {

			player = GameObject.FindGameObjectWithTag(collider.tag);
			detectedPlayer = true;
			DoAttack();	
		}
	}

	void OnTriggerExit2D(Collider2D collider){

		detectedPlayer = false;

		}

	void DoAttack(){

		cooldownTimer -= Time.deltaTime;

		if (cooldownTimer <= 0) {
			
			cooldownTimer = firedelay;
			
			Vector3 offset = transform.rotation * bulletOffset;
			
			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			
		}


	}
}
