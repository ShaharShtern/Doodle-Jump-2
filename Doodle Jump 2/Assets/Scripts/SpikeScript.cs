using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public float rotateSpeed;
    public GameObject lostCanvas;
    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hitbox"))
        {
            //make the player fall down when touching spikes
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            Rigidbody rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
            rb.velocity = new Vector3(rb.velocity.x / 2, rb.velocity.y, rb.velocity.z);
            //change player tag so they dont jump on platforms once dead
            other.gameObject.tag = "Dead";
        }
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed*Time.deltaTime));
    }
}
