using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMovement : MonoBehaviour {

	[SerializeField]
	private int sidespeed;

	[SerializeField]
	private int advance;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();		
	}

	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.forward * advance * Time.deltaTime);

		//Vector3 movement = new Vector3(0.0f, JumpPower, 0.0f);


		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(sidespeed * Time.deltaTime, 0,0);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-sidespeed * Time.deltaTime, 0,0);
		}

	}
}
