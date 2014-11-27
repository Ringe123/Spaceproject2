using UnityEngine;
using System.Collections;

public class PlanetGravitation : MonoBehaviour {

	public float gravitationPull;
	GameObject unit;
	bool beingPulled = false;
	public Texture2D guiIcon;
	string unitTag;

	void OnTriggerEnter2D(Collider2D collider){

		unitTag = collider.tag;
		unit = GameObject.FindGameObjectWithTag (unitTag);
		beingPulled = true;

	}

	void OnTriggerExit2D(Collider2D collider){

		beingPulled = false;

	}

	void Update(){

		if (unit != null) {
						if (beingPulled == true) {
								
								//TODO fixa högre gravitation ju närmre mitten
								//Vector3 orbitCenter = transform.position;
								//float distance = Vector3.Distance(orbitCenter, unit.transform.position);
								
								unit.transform.position = Vector3.Lerp (unit.transform.position, transform.position, gravitationPull * Time.deltaTime);

						}
				}
	}

	void OnGUI(){

		if (beingPulled == true) {

			GUI.Label(new Rect(100, 100 , 100,50), guiIcon);


				}

	}
}
