using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public bool MusicMuted;
	GameObject HPText;

	void Start(){

		HPText = GameObject.Find ("HUDCanvas").GetComponent<Heal>;

	}

	public void StartNewGame(string level){

		Application.LoadLevel (level);

	}

	public void MuteMusic(bool mute){

		MusicMuted = mute;

	}

	void Update(){




	}

}
