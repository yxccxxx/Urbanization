using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPressure : MonoBehaviour {
	public GameObject door;
	//private TouchArrow arrow = GetComponent<TouchArrow>();
	bool touched = TouchArrow.touched;
	// Update is called once per frame
	void Update () {
		if(touched){
			disappear();
		}else{
			appear();
		}
	}

	void disappear(){
		door.SetActive(false);
	}

	void appear(){
		door.SetActive(true);
	}
}
