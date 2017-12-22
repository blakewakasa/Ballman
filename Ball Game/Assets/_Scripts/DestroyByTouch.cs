using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTouch : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
		FindObjectOfType<GameManager> ().EndGame();
		Destroy(other.gameObject);		
	}
}
