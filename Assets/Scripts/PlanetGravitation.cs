using UnityEngine;
using System.Collections;

public class PlanetGravitation : MonoBehaviour {

	public float gravitationPull;
	GameObject unit;
	bool beingPulled = false;
	public Texture2D guiIcon;
	public float shinkrate = 0.5f;
	string unitTag;

	void OnTriggerEnter2D(Collider2D collider){

		unitTag = collider.tag;
		Debug.Log (collider.name);
		//unit = GameObject.FindGameObjectWithTag (unitTag);
		unit = GameObject.Find (collider.name);
		beingPulled = true;

	}

	void OnTriggerExit2D(Collider2D collider){

		Debug.Log ("kommer hit");
		beingPulled = false;
		unit = null;
	}

	void Update(){

		Debug.Log (beingPulled);

		if (unit != null) {
				if (beingPulled == true) {
								
						//TODO fixa högre gravitation ju närmre mitten

						float test = unit.transform.localScale.x * -1;
						unit.transform.localScale = new Vector3(unit.transform.localScale.x - shinkrate * Time.deltaTime, unit.transform.localScale.y - shinkrate * Time.deltaTime, unit.transform.localScale.z);
						unit.transform.position = Vector3.Lerp (unit.transform.position, transform.position, test * Time.deltaTime);					
						
						if (unit.transform.localScale.x <= 0) {

							Destroy(unit);
							
								}
						}
				}
	}

	void OnGUI(){

		if (beingPulled == true) {

			GUI.Label(new Rect(0, 0 , 100,50), guiIcon);


				}

	}
}
