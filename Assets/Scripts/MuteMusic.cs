using UnityEngine;
using System.Collections;

public class MuteMusic : MonoBehaviour {


	GameObject gameManager;
	// Use this for initialization
	void Start () {

		gameManager = GameObject.Find("GameManager");

	}
	
	// Update is called once per frame
	void Update () {

		if (gameManager.GetComponent<MenuScript>().MusicMuted) {
			
			audio.Stop();
			
		}
		
	}
}
