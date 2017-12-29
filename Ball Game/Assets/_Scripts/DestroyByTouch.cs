using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTouch : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
        SizeChange.isSmall = false;
        SizeChange.isRegular = true;
        SizeChange.isBig = false;
		FindObjectOfType<GameManager> ().EndGame();
		Destroy(other.gameObject);		
	}
}
