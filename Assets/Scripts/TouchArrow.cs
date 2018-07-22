using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.String.Equals;

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
		if(String.Equals(other.gameObject.name, "Arrow") == true){
			touched = true;
		}

    }

	void onCollisionExit (Collision other)
	{
		touched = false;
	}
}
