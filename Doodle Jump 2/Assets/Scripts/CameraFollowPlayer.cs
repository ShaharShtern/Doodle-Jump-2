using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float offset;
    void Update()
    {
        transform.Translate(0, 1 * Time.deltaTime, 0);
        float newYPosition = playerTransform.position.y + offset;
        //check to make sure camera only goes up
        if (newYPosition>transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);
        }
    }
}
