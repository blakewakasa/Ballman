using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    
    public float seconds, minutes;
    public Text timerText;
    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();
        
    }
        // Update is called once per frame
        void Update () {
        minutes = (int)(Time.timeSinceLevelLoad/ 60f);
        
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        
        timerText.text= minutes.ToString("0") + ":" + seconds.ToString("00");
	}
}
