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

    public object SizeChange { get; private set; }

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody> ();
        
        originalspeed = sidespeed;
        originaladvance = advance;
        
	}

	// Update is called once per frame
	void FixedUpdate () {
		
        //rb.velocity = new Vector3(0.0f,0.0f , advance);
        rb.velocity = new Vector3(0.0f, rb.velocity.y, advance);

        speedCheck();
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
    void speedCheck()
    {
        if (ChangeSize.isSmall)
        {
            sidespeed = originalspeed *2;
            advance = originaladvance*2;
        }
        else if (ChangeSize.isBig)
        {
            sidespeed =originalspeed/ 2;
            advance = originaladvance/ 2;
        }
        else
        {
            sidespeed = originalspeed;
            advance = originaladvance;
        }
    }
}
