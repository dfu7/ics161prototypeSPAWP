using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    [SerializeField] private PlayerSpawn _spawn;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            // increase score
            Score.score += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            // win
            Debug.Log("end game");
        }
        else
        {
            // respawn
            _spawn.respawn();
        }
    }
}
