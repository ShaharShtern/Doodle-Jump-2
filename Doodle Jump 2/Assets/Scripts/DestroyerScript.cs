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
        }
    }
}
