using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	[Range(1,10)]
	public float jumpVelocity;
    public Vector3 jump;
    [Range(1,10)]
    public float jumpForce; //testing out forces

    public float fallMultiplier = 2.5f; //Holding Jump
	public float lowJumpMultiplier = 2f;//Tab Jump
	public bool AirBound;
	Rigidbody rb;
    void Start()
    {
        
    }
    void Awake(){
		rb = GetComponent<Rigidbody> ();
        
        AirBound = false;
	}

	void Update(){

		if (AirBound == false) {
			

			if (Input.GetButtonDown ("Jump")) {
                //rb.velocity = Vector3.up * jumpVelocity;
                
                rb.AddForce(jump *jumpForce, ForceMode.Impulse);//trying out this instead of the velocity for jumping needs a vector3
				AirBound = true;
			}
			if (rb.velocity.y < 0) {
				rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
			
			} else if (rb.velocity.y > 0 && !Input.GetButton ("Jump")) {
				rb.velocity = Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;

			}
		}
	}
	void OnCollisionEnter(Collision other){
		AirBound = false;

		}
}
