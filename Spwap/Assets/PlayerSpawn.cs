using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    public void respawn()
    {
        SceneManager.LoadScene(1);
    }
}
