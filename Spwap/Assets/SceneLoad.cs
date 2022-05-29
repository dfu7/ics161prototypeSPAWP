using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    // level = int
    // Index of scenes
    public void LoadLevel(int lvl)
    {
        SceneManager.LoadScene(lvl);    
    }
}
