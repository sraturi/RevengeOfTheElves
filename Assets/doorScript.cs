﻿using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void doorOpener()
    {
        Debug.Log("it went through");
        gameObject.GetComponent<Animation>().Play();
    }
}
