using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenPlatformScript : MonoBehaviour
{
    [Range(5, 20)]
    public float jumpPower;
    void Start()
    {

    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
                Rigidbody rbPlatform = GetComponent<Rigidbody>();
                //make the platform fall when the player jumps on it
                rbPlatform.useGravity = true;
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
