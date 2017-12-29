using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOff : MonoBehaviour {
    private float bottom;
    public GameObject Ground;
	// Use this for initialization
	void Start () {
        bottom = Ground.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (Ground.transform.position.y>this.transform.position.y)
        {
            SizeChange.isSmall = false;
            SizeChange.isRegular = true;
            SizeChange.isBig = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
