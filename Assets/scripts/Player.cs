using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   

    //Walk
     public float speed;
     private Rigidbody _rigidBody;
    //Jump
     public float height;
     //Vector3 Vec; 
     private bool isOnFloor = true;
    
    // Start is called before the first frame update
    void Start()
    {
         _rigidBody = GetComponent<Rigidbody>();
         speed = 3.0f;
         height = 3.0f;

    }

 
 void FixedUpdate()
    {
        //Walk
        float horizontalValue = Input.GetAxisRaw("Horizontal");
        float verticalValue = Input.GetAxisRaw("Vertical");

        _rigidBody.AddForce(Vector3.forward * speed * verticalValue * Time.deltaTime * 20);
        _rigidBody.AddForce(Vector3.right * speed * horizontalValue * Time.deltaTime * 20);
    // //     // Vec = transform.localPosition;  
    // //     // Vec.y += Input.GetAxis("Jump") * height * Time.deltaTime * 20;  
    // //     // Vec.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime * 20;  
    // //     // Vec.z += Input.GetAxis("Vertical") * speed * Time.deltaTime * 20;  
    // //     // transform.localPosition = Vec;  
         
    
        //Jump
        if (isOnFloor && Input.GetButton("Jump"))
        {
            isOnFloor = false;
            _rigidBody.AddForce(Vector3.up * height, ForceMode.Impulse);
        }
    }

    //Jump
    private void OnCollisionEnter(Collision other) {
        isOnFloor = true;
    }
    
}

