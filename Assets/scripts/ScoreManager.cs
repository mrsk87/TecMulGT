using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    
    int score=0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        ScoreText.text = "Score: " + score.ToString();

    }
}
