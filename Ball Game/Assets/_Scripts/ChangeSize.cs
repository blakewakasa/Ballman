using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour {
    public Vector3 ratioChange;
    public static bool isBig = false;
    public static bool isSmall = false;
    public static bool isRegular = true;
    private Vector3 originalSize;

    //public Animator playerAnim; 
    // Use this for initialization
    void Start () {
        originalSize = transform.localScale;
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
        else if (Input.GetKeyDown(KeyCode.W) &&!isRegular)
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
        transform.localScale = originalSize-ratioChange;
        /*for (float i = 0.0f; i / 10 < ratioChange.x; ++i)
        
            transform.localScale -= new Vector3(ratioChange.x / 10, ratioChange.y / 10, ratioChange.z / 10);
        */
    }
    private void changeRegular()
    {
        transform.localScale = originalSize;
    }
    private void changeBig()
    {
        transform.localScale = originalSize+ratioChange;
    }
    /*private void toSmallAnim()
    {
        if (isRegular)
        {
            playerAnim.SetTrigger("KeyPressed");
           
        }
    }*/
}

    