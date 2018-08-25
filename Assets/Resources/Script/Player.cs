using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			Vector3 tempPos = gameObject.transform.position;
			tempPos.x -= speed * Time.deltaTime;
			gameObject.transform.position = tempPos;
		}
		if (Input.GetKey(KeyCode.D)) {
			Vector3 tempPos = gameObject.transform.position;
            tempPos.x += speed * Time.deltaTime;
            gameObject.transform.position = tempPos;
		}
		if (Input.GetKey(KeyCode.W)) {
			Vector3 tempPos = gameObject.transform.position;
            tempPos.y += speed * Time.deltaTime;
            gameObject.transform.position = tempPos;
  		}
		if (Input.GetKey(KeyCode.S)) {
			Vector3 tempPos = gameObject.transform.position;
            tempPos.y -= speed * Time.deltaTime;
            gameObject.transform.position = tempPos;
		}
	}
}
