using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityAppear : MonoBehaviour {
	public GameObject door;
	// Use this for initialization
	void Start () {
		door.SetActive(true);

	}

	// Update is called once per frame
	void Update () {
		
    	bool touched = CityTrigger.touched;
        Debug.Log("city touch value is "+touched);
		if(touched){
			appear();
		}
	}

	void appear(){
		door.SetActive(true);
    }
}
