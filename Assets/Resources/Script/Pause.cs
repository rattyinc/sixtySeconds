using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
		if (Player.Instance != null) {
			var p = GameObject.Find("Player");
			if (p != null) {
				Player.Instance.gameObject.transform.parent = p.transform;
				Player.Instance.gameObject.transform.localPosition = new Vector3(0, 0, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			paused = !paused;
		}	
		if (paused)
		{
			Time.timeScale = 0;
		}
		else if (!paused)
		{
			Time.timeScale = 1;

		}
	}
}
