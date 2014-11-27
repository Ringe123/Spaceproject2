using UnityEngine;
using System.Collections;

public class bulletSelfDestruct : MonoBehaviour {

	public float bulletLiveTime = 5f;

	void Update () {
	
		bulletLiveTime -= Time.deltaTime;

		if (bulletLiveTime <= 0) {

			Destroy(gameObject);

				}

	}
}
