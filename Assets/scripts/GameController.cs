using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int numberCollectables;
    public GameObject endMessage;

    timer _timer;
    
    // Start is called before the first frame update
    void Start()
    {
        numberCollectables = 4;
        _timer = timer.Instance; 
        }

    // Update is called once per frame
    void Update()
    {
        //Display Game Over message
        if (numberCollectables == 0)
        {
            _timer.Finish();
            endMessage.SetActive(true);
        }
    }
}
