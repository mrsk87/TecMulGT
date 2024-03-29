using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private GameObject gController;

    private void Start() {
        //Get Game Controller
        gController = GameObject.Find("Game Controller");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player")
        {
            //Delete Collectable
            Destroy(gameObject);
            //Update stored number of Collectables
            gController.transform.GetComponent<GameController>().numberCollectables -= 1;
            ScoreManager.instance.AddPoint();
        }
    }
}
