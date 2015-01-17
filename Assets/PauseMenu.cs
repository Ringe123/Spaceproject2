using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	bool isPaused = false;


	// Update is called once per frame
	void Update () {


		if (Input.GetButton("Cancel")) {
					
					isPaused = !isPaused;

					if (isPaused) {
						Time.timeScale = 0;
					}
					else{
						Time.timeScale = 1;
						
					}
				}
	
	}
}
