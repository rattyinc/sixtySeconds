using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {
public GameObject Nextthing;
public GameObject Oldthing;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		Nextthing.SetActive(true);
		Debug.Log("CONTACT");
		Oldthing.SetActive(false);
	}

}
