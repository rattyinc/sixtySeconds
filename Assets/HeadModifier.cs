using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadModifier : MonoBehaviour {

	public Sprite[] heads;
	private int headInt = 0;

	public Sprite[] hairs;
	private int hairInt;

	public Color[] eyeColors;
	private int eyeColorInt = 0;

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
		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		sr.sprite = heads[headInt];
	}

	public void updateHair(bool left)
    {
        if (left)
        {
            if (hairInt == 0)
            {
				hairInt = hairs.Length - 1;
            }
            else
            {
				hairInt -= 1;
            }
        }
        else
        {
			if (hairInt == hairs.Length - 1)
            {
				hairInt = 0;
            }
            else
            {
				hairInt += 1;
            }
        }
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		sr.sprite = hairs[hairInt];
    }

	public void updateEyes(bool left)
    {
		if (left)
        {
            if (eyeColorInt == 0)
            {
				eyeColorInt = eyeColors.Length - 1;
            }
            else
            {
				eyeColorInt -= 1;
            }
        }
        else
        {
			if (eyeColorInt == eyeColors.Length - 1)
            {
				eyeColorInt = 0;
            }
            else
            {
				eyeColorInt += 1;
            }
        }
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		sr.color = eyeColors[eyeColorInt];
    }
}
