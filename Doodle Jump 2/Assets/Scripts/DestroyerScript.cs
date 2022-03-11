using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    public GameObject lostCanvas;
    private void OnTriggerEnter(Collider other)
    {
        //destroy objects
        if (other.CompareTag("Object"))
        {
            Destroy(other.gameObject);
        }
        //display lost screen when player falls
        if(other.GetComponent<PlayerMovement>())
        {
            lostCanvas.SetActive(true);
            other.transform.position = new Vector3(10, 0, 0);
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = new Vector3(0, 0, 0);
            int endScore = other.GetComponent<PlayerStats>().score;
            if (endScore>PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", endScore);
            }
        }
    }
}
