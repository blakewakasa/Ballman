using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTouch : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
        SizeChange.ResetAll();
		FindObjectOfType<GameManager> ().EndGame();
		Destroy(other.gameObject);		
	}
}
