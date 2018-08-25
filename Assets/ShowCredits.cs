using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCredits : MonoBehaviour {

	private bool execute;
	public GameObject Credits;
	// Use this for initialization
	void Start () {
		execute = false;
		StartCoroutine("timer");
	}
	
	// Update is called once per frame
	void Update () {
		if (execute == true)
		{
			Credits.SetActive(true);

		}
	}

	IEnumerator timer()
	{
		yield return new WaitForSeconds(4);
		execute = true;
		Debug.Log("test");
	}

}
