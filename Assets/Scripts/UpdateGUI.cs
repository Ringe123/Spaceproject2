using UnityEngine;
using System.Collections;

public class UpdateGUI : MonoBehaviour {
	
	GameObject player;
	DamageHandler damagehandler;
	int hp;

	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		DamageHandler damagehandler = player.GetComponent<DamageHandler>();

	}
	
	// Update is called once per frame
	void Update () {
		hp = player.GetComponent<DamageHandler>().getCurrentHP();
		GUIText guitext = GetComponentInChildren<GUIText>();
		guitext.text = hp.ToString();
	}
}
