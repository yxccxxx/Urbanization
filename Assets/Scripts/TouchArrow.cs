﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchArrow : MonoBehaviour {
	public static bool touched = false;
    public GameObject box;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other) 
    {
        if (other.gameObject.name.Equals(box.name)) {
			touched = true;
            Debug.Log("touched!!!!!!!!!!!!!!!!!!!!=============================");
        }

    }

	void onCollisionExit (Collision other)
	{
        Debug.Log("No longer touching");
        if (other.gameObject.name.Equals(box.name))
        {
            Debug.Log("turn to false");
            touched = false;
        }
	}

}
