using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchArrow : MonoBehaviour {
	public static bool touched = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other) 
    {
	    //if(String.Equals(other.gameObject.name, "Arrow") == true){
        if (other.gameObject.name.Equals("Arrow")) {
			touched = true;
		}

    }

	void onCollisionExit (Collision other)
	{
		touched = false;
	}
}
