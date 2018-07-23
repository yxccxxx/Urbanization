using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownOpen : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        bool touched = NewFacTrigger.touched;
      //  Debug.Log("touch value is =="+touched);
		if(touched){
			disappear();
		}else{
			appear();
		}
	}

	void disappear(){
      //  Debug.Log("Should turn to false???");
        GetComponent<Renderer>().enabled = false;
	}

	void appear(){
        GetComponent<Renderer>().enabled = true;
    }
}
