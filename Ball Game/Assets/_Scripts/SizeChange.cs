using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour {
    public Vector3 ratioChange;
    private static bool isBig = false;
    private static bool isSmall = false;
    private static bool isRegular = true;

    //public Animator playerAnim; 
    // Use this for initialization
    void Start () {
       // playerAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.Q) && !isSmall)
        {
           // toSmallAnim();
            changeSmall();
            isSmall = true;
            isBig = false;
            isRegular = false;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            changeRegular();
            isRegular = true;
            isBig = false;
            isSmall = false;
        }
        else if (Input.GetKeyDown(KeyCode.E)&&!isBig)
        {
            changeBig();
            isBig = true;
            isSmall = false;
            isRegular = false;
        }

            }
    private void changeSmall()
    {
        transform.localScale -= ratioChange;
        /*for (float i = 0.0f; i / 10 < ratioChange.x; ++i)
        
            transform.localScale -= new Vector3(ratioChange.x / 10, ratioChange.y / 10, ratioChange.z / 10);
        */
    }
    private void changeRegular()
    {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
    private void changeBig()
    {
        transform.localScale += ratioChange;
    }
    /*private void toSmallAnim()
    {
        if (isRegular)
        {
            playerAnim.SetTrigger("KeyPressed");
           
        }
    }*/
}

    