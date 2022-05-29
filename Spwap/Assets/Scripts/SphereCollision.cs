using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            // increase score
            Debug.Log("Increase Score");
            Destroy(collision.gameObject);
        }
        else
        {
            // respawn
            Debug.Log("Respawn");
        }
    }
}
