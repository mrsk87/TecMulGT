using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool finnished = false;

    public static timer Instance;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(finnished)
            return;
        float t = Time.time - startTime;
        string minutes = ((int) t/60).ToString();
        string seconds = (t%60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
    }

    public void Finnish() {
        finnished = true;
        timerText.color = Color.yellow;
    }
}
