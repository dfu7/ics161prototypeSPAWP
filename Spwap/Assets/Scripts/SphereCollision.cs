using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{
    [SerializeField] private SceneLoad _spawn;
    [SerializeField] private GameObject _panel;
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
            _panel.SetActive(true);

        }
        else
        {
            // respawn
            _spawn.LoadLevel(1);
        }
    }
}
