using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadModifier : MonoBehaviour {

	public Sprite[] heads;
	private int headInt = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateHead(bool left) {
		if (left) {
			if (headInt == 0) {
				headInt = heads.Length - 1;
			}
			else {
				headInt -= 1;
			}
		} else {
			if (headInt == heads.Length - 1) {
               headInt = 0;
            }
            else {               
                headInt += 1;
            }
		}
		Debug.Log("Sprite name: "+gameObject.name);
		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		sr.sprite = heads[headInt];
	}
}
