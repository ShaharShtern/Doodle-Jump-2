using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        //move player to other side when out of bounds
        if (transform.position.x<-6f)
            transform.position = new Vector3(6f, transform.position.y, transform.position.z);
        if (transform.position.x >6f)
            transform.position = new Vector3(-6f, transform.position.y, transform.position.z);
    }
    private void FixedUpdate()
    {
        //create horizontal movement
        //float that is controlled by player input
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower;
        //new vector that is the player's velocity
        Vector3 newMovement = rb.velocity;
        //change x velocity to that of the input
        newMovement.x = horizontalMovement;
        //assign new velocity to player velocity
        rb.velocity = newMovement;
    }
}
