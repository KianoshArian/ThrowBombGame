using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {
    public float timer;
    public Text timerText;
    // Use this for initialization
    void Start () {
        timer = 15;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 0)
            timer -= Time.deltaTime;
        else
            timer = 0;
        if(timer>=10)
            timerText.text="00:"+((int)timer).ToString();
        else
            timerText.text = "00:0" + ((int)timer).ToString();
    }
}
