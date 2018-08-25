using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;

    public Sprite[] hairs;
    private int hairInt;

	public Sprite[] heads;
    private int headInt = 0;

    public Color[] colors;
    private int eyeColorInt = 0;
    private int topColorInt = 0;
	private int botColorInt = 0;

	private int[] charInts = new int[5];
    
	private static Player instance = null;
    public static Player Instance
    {
        get { return instance; }
    }

	// Use this for initialization
	void Start () {
		
	}

	void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
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
		if (Input.GetKey(KeyCode.Space)) {
		}
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
		var hair = gameObject.transform.Find("Hair");
        var sr = hair.gameObject.GetComponent<SpriteRenderer>();
		sr.sprite = hairs[hairInt];
		charInts[0] = hairInt;
    }

	public void updateEyes(bool left)
    {
		if (left)
        {
            if (eyeColorInt == 0)
            {
				eyeColorInt = colors.Length - 1;
            }
            else
            {
				eyeColorInt -= 1;
            }
        }
        else
        {
			if (eyeColorInt == colors.Length - 1)
            {
				eyeColorInt = 0;
            }
            else
            {
				eyeColorInt += 1;
            }
        }
		var eyes = gameObject.transform.Find("Right Eye");
		var sr = eyes.gameObject.GetComponent<SpriteRenderer>();
		sr.color = colors[eyeColorInt];
		charInts[1] = eyeColorInt;
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
		var head = gameObject.transform.Find("Head");
		var sr = head.gameObject.GetComponent<SpriteRenderer>();
		sr.sprite = heads[headInt];
		charInts[2] = headInt;
	}

	public void updateTopClothesColor(bool left) {
		if (left)
        {
			if (topColorInt == 0)
            {
				topColorInt = colors.Length - 1;
            }
            else
            {
				topColorInt -= 1;
            }
        }
        else
        {
			if (topColorInt == colors.Length - 1)
            {
				topColorInt = 0;
            }
            else
            {
				topColorInt += 1;
            }
        }
		var torso = gameObject.transform.Find("Torso");
        var sr = torso.gameObject.GetComponent<SpriteRenderer>();
		sr.color = colors[topColorInt];
		charInts[3] = topColorInt;
	}
	
	public void updateBotClothesColor(bool left) {
		if (left)
        {
			if (botColorInt == 0)
            {
				botColorInt = colors.Length - 1;
            }
            else
            {
				botColorInt -= 1;
            }
        }
        else
        {
			if (botColorInt == colors.Length - 1)
            {
				botColorInt = 0;
            }
            else
            {
				botColorInt += 1;
            }
        }
		var legs = gameObject.transform.Find("Legs");
		var sr = legs.gameObject.GetComponent<SpriteRenderer>();
		sr.color = colors[botColorInt];
		charInts[4] = botColorInt;
	}
}
