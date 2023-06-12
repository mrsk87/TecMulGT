using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int numberCollectables;
    public GameObject endMessage;

    
    
    // Start is called before the first frame update
    void Start()
    {
        numberCollectables = 16;
        
        }

    // Update is called once per frame
    void Update()
    {
        //Display Game Over message
        if (numberCollectables == 0)
        {
            timer.Instance.Finnish();
            endMessage.SetActive(true);
        }
    }
}
