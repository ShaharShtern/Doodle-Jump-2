using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    [Range(5, 20)]
    public float jumpPower;
    public int moveCounter;
    public int moveRange;
    public float moveSpeedMax;
    public float moveSpeedMin;
    float moveSpeed;
    bool direction;
    void Start()
    {
        //reset spawn position so they dont move out of bounds
        transform.position = new Vector3(Random.Range(-3, 3), transform.position.y, transform.position.z);
        //give each platform random speed
        moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
    }
    //test

    private void FixedUpdate()
    {
        //left right movement
        if (direction)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            moveCounter++;
            if (moveCounter>moveRange*Time.deltaTime)
            {
                direction = false;
            }
        }
        else
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            moveCounter--;
            if (moveCounter<-moveRange*Time.deltaTime)
            {
                direction = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //jump
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);
            }
        }
    }
}
