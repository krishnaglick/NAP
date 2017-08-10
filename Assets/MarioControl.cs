using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioControl : MonoBehaviour {

  public GameObject mario;

  public Sprite standRight;
  public Sprite standLeft;

  private bool facingRight = true;

	void Start () {
  }
	
	// Update is called once per frame
	void Update() {
    if (Input.GetKey(KeyCode.RightArrow)) {
      mario.GetComponent<Animator>().Play("walk_right");
      mario.GetComponent<Animator>().enabled = true;
      facingRight = true;
    }
    else if(Input.GetKey(KeyCode.LeftArrow)) {
      mario.GetComponent<Animator>().Play("walk_left");
      mario.GetComponent<Animator>().enabled = true;
      facingRight = false;
    }
    else if (Input.GetKey(KeyCode.UpArrow)) {
      mario.GetComponent<Animator>().enabled = true;
      if(facingRight)
        mario.GetComponent<Animator>().Play("jump_right");
      else
        mario.GetComponent<Animator>().Play("jump_left");
    }
    else {
      mario.GetComponent<Animator>().enabled = false;
      if (facingRight)
        mario.GetComponent<SpriteRenderer>().sprite = standRight;
      else
        mario.GetComponent<SpriteRenderer>().sprite = standLeft;
    }
  }
}
