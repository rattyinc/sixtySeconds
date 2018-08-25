using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesModifier : MonoBehaviour {

	public Color[] colors;
	private int colorInt = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateClothesColor(bool left) {
		if (left)
        {
			if (colorInt == 0)
            {
				colorInt = colors.Length - 1;
            }
            else
            {
				colorInt -= 1;
            }
        }
        else
        {
			if (colorInt == colors.Length - 1)
            {
				colorInt = 0;
            }
            else
            {
				colorInt += 1;
            }
        }
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();
		sr.color = colors[colorInt];
	}
}
