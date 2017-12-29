using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour {

	[SerializeField]
	private int sidespeed;
    private int originalspeed;
    private Vector3 truespeed;
	[SerializeField]
	private int advance;
    private int originaladvance;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        originaladvance = advance;
        originalspeed = sidespeed;
	}

	// Update is called once per frame
	void FixedUpdate () {
        CheckSpeed();
        //rb.velocity = new Vector3(0.0f,0.0f , advance);
        rb.velocity = new Vector3(0.0f, rb.velocity.y, advance);
        
        
		if (Input.GetKey(KeyCode.RightArrow))
		{
            /*if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }*/
            rb.velocity = (new Vector3(sidespeed, rb.velocity.y, advance));
			//transform.Translate(sidespeed * Time.deltaTime, 0,0);
		}

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            /*if (rb.velocity.x > 0)
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            }*/
            rb.velocity =(new Vector3(-sidespeed, rb.velocity.y, advance));
			//transform.Translate(-sidespeed * Time.deltaTime, 0,0);
		}

	}
    void CheckSpeed()
    {
        if(SizeChange.isSmall)
        {
            sidespeed = originalspeed * 2;
            advance = originaladvance * 2;
        }
        else if(SizeChange.isRegular)
        {
            sidespeed = originalspeed;
            advance = originaladvance;
        }
        else if(SizeChange.isBig)
        {
            sidespeed = originalspeed / 2;
            advance = originaladvance / 2;
        }
    }
}
