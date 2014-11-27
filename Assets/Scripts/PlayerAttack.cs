using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject bulletPrefab;
	public Vector3 bulletOffset = new Vector3(0,0.5f ,0);

	public float firedelay = 0.25f;
	float cooldownTimer = 0;
	
	// Update is called once per frame
	void Update () {

		cooldownTimer -= Time.deltaTime;

		if (Input.GetButton("Fire1") && cooldownTimer <= 0) {

			cooldownTimer = firedelay;

			Vector3 offset = transform.rotation * bulletOffset;

			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);

				}
	
	}
}
