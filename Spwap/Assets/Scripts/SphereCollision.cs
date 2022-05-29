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
            Score.score += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "win area")
        {
            // win
            Debug.Log("end game");
        }
        else
        {
            // respawn
            Debug.Log("Respawn");
        }
    }
}
