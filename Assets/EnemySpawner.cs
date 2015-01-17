using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	public float spawnTime;
	float spawnTimer;
	int enemyID = 1;

	// Use this for initialization
	void Start () {
		spawnTimer = spawnTime;
	
	}
	
	// Update is called once per frame
	void Update () {

		spawnTimer -= Time.deltaTime;

		if (spawnTimer <= 0) {
			spawnTimer = spawnTime;

			Object enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
			enemy.name = "enemy" + enemyID;
			enemyID++;
				}

	
	}
}
