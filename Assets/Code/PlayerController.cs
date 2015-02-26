using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public KeyCode MoveLeft;
  public KeyCode MoveRight;

	// Use this for initialization
	void Start () {
	
	}

  private float speed = 20;
  
	// Update is called once per frame
	void Update () {
	  var cPos = rigidbody2D.position;

    if(Input.GetKey(MoveLeft))
    {
      transform.position += Vector3.left * speed * Time.deltaTime;
      //rigidbody2D.AddForce(new Vector2(-speed, 0));
    //  rigidbody2D.MovePosition(cPos + new Vector2(Time.deltaTime * -speed, 0));
    }
    else if(Input.GetKey(MoveRight))
    {
      transform.position += Vector3.right * speed * Time.deltaTime;
      //rigidbody2D.AddForce(new Vector2(speed, 0));
     // rigidbody2D.MovePosition(cPos + new Vector2(Time.deltaTime * speed, 0));
    }


	}
  

  void OnTriggerStay2D(Collider2D coll)
  {
    if (coll.gameObject.tag == "ArrowUp")
      rigidbody2D.velocity = new Vector2(0, Time.deltaTime * 1300);
    if (coll.gameObject.tag == "ArrowDown")
      rigidbody2D.velocity = new Vector2(0, Time.deltaTime * -1300);
    if (coll.gameObject.tag == "ArrowLeft")
      rigidbody2D.velocity = new Vector2(Time.deltaTime * -1300, 0);
    if (coll.gameObject.tag == "ArrowRight")
      rigidbody2D.velocity = new Vector2(Time.deltaTime * 1300, 0);
  }

}
