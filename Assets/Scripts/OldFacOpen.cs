using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldFacOpen : MonoBehaviour {
	public GameObject door;

	// Update is called once per frame
	void Update () {
        bool touched = FarmTrigger.touched;
      //  Debug.Log("touch value is =="+touched);
		if(touched){
			disappear();
		}else{
			appear();
		}
	}

	void disappear(){
      //  Debug.Log("Should turn to false???");
		//door.SetActive(false);
        GetComponent<Renderer>().enabled = false;
	}

	void appear(){
        //door.SetActive(true);
        GetComponent<Renderer>().enabled = true;
    }
}
