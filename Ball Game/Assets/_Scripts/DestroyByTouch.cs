using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTouch : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
        ChangeSize.isBig = false;
        ChangeSize.isSmall = false;
        ChangeSize.isRegular = true;
		FindObjectOfType<GameManager> ().EndGame();
		Destroy(other.gameObject);	
	}
}
