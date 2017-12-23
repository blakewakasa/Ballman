using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour {

	[SerializeField]
	private int sidespeed;
    private Vector3 truespeed;
	[SerializeField]
	private int advance;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        
	}

	// Update is called once per frame
	void FixedUpdate () {
		
        //rb.velocity = new Vector3(0.0f,0.0f , advance);
        rb.velocity = new Vector3(0.0f, 0.0f, advance);
        

		if (Input.GetKey(KeyCode.RightArrow))
		{
            /*if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }*/
            rb.velocity = (new Vector3(sidespeed, 0.0f, advance));
			//transform.Translate(sidespeed * Time.deltaTime, 0,0);
		}

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            /*if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }*/
            rb.velocity =(new Vector3(-sidespeed, 0.0f, advance));
			//transform.Translate(-sidespeed * Time.deltaTime, 0,0);
		}

	}
}
