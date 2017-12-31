using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideBall : MonoBehaviour {

	public Transform Ball;
	public Animator anim;
	public float midsize;
	public float smallsize;
	public float bigsize;
	private float floor;

	// Use this for initialization
	void Start () {
		floor = midsize;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Ball.position.x, Ball.position.y - floor, Ball.position.z);


		if (Input.GetKeyDown (KeyCode.E)) {
			transform.localScale = new Vector3 (.7f,.7f,1.2f);
			floor = bigsize;

		}
		else if (Input.GetKeyDown (KeyCode.Q)) {
			transform.localScale = new Vector3 (.25f,.25f,.5f);
			floor = smallsize;
			//transform.position = new Vector3 (Ball.position.x, Ball.position.y - smallsize, Ball.position.z);

		}
		else if (Input.GetKeyDown (KeyCode.W)) {
			transform.localScale = new Vector3 (.5f,.5f,1f);
			//transform.position = new Vector3 (Ball.position.x, Ball.position.y - midsize, Ball.position.z);
			floor = midsize;
		}

		/*if (Input.GetKeyDown (KeyCode.RightArrow)) {
			anim.Play("RUN00_R");

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			anim.Play("RUN00_L");
		}*/
	}
}
