using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [Range(5, 20)]
    public float jumpPower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y <0)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z); 
                GetComponent<AudioSource>().Play();
            }
           
        }
    }
}
