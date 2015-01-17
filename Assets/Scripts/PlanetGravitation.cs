using UnityEngine;
using System.Collections.Generic;

public class PlanetGravitation : MonoBehaviour {

	public float gravitationPull;
	//GameObject unit;
	bool beingPulled = false;
	public Texture2D guiIcon;
	public float shinkrate = 0.5f;
	string unitTag;
	List<GameObject> gravityList;

	void Start(){

		gravityList = new List<GameObject>();

	}

	void OnTriggerEnter2D(Collider2D collider){

		unitTag = collider.tag;
		GameObject unit = GameObject.Find (collider.name);
		if (unit != null && collider.tag != "BigEnemy") {

			Debug.Log (collider.name + "reagerar på triggerenter");
			beingPulled = true;
			gravityList.Add (unit);

				}

	}

	void OnTriggerStay2D(Collider2D collider){

		GameObject crashedUnit = null;

		foreach (var unit in gravityList) {

					unit.transform.localScale = new Vector3(unit.transform.localScale.x - shinkrate * Time.deltaTime, 
			                                        		unit.transform.localScale.y - shinkrate * Time.deltaTime,
			                                        		unit.transform.localScale.z);
					unit.transform.position = Vector3.Lerp (unit.transform.position, transform.position, gravitationPull * Time.deltaTime);		

						if (unit.transform.localScale.x <= 0.2) {
							
							audio.Play();	
							crashedUnit = unit;
							//Destroy(unit);
							
						}
					}
		if (crashedUnit != null) {

			Destroy(crashedUnit);
			gravityList.Remove(crashedUnit);
				}


	}

	void OnTriggerExit2D(Collider2D collider){

		if (collider != null && collider.tag != "BigEnemy") {
					GameObject unit = collider.gameObject;
					Debug.Log (collider.name + "reagerar på triggerExit");
					beingPulled = false;
					unit.transform.localScale = new Vector3 (1,1,1);
					unit = null;
					gravityList.Remove(unit);

				}
	}

	void Update(){
		/*	
		if (unit != null) {

				if (beingPulled == true) {
								
						//TODO fixa högre gravitation ju närmre mitten

						float test = unit.transform.localScale.x * -1;
						unit.transform.localScale = new Vector3(unit.transform.localScale.x - shinkrate * Time.deltaTime, unit.transform.localScale.y - shinkrate * Time.deltaTime, unit.transform.localScale.z);
						unit.transform.position = Vector3.Lerp (unit.transform.position, transform.position, gravitationPull * Time.deltaTime);					
						
						if (unit.transform.localScale.x <= 0.2) {
									
								audio.Play();						
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
	*/
	}
}
