using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityAppear : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
	}

	// Update is called once per frame
	void Update () {
        bool touched = CityTrigger.touched;
      //  Debug.Log("touch value is =="+touched);
		if(touched){
			appear();
		}
	}

	void appear(){
        GetComponent<Renderer>().enabled = true;
    }
}
