using UnityEngine;
using System.Collections;

public class DetectandAttack : MonoBehaviour {

	public GameObject player; 
	public GameObject bulletPrefab;
	public bool detectedPlayer = false;
	public float firedelay = 0.25f;
	float cooldownTimer = 0;
	public Vector3 bulletOffset = new Vector3(0,0.5f ,0);
	public Vector3 bulletOffset2 = new Vector3(0,0.5f ,0);
	public GameObject target;

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

		Debug.Log ("ontriggerenter");

		if (collider.tag == "Player") {
			Debug.Log(collider);
			player = collider.gameObject;
			detectedPlayer = true;
			DoAttack();	

			// GameObject.FindGameObjectWithTag(collider.tag);
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
			Vector3 offset2 = transform.rotation * bulletOffset2;

			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			Instantiate(bulletPrefab, transform.position + offset2, transform.rotation);
			
		}


	}
}
