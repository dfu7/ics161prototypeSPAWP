using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void SceneLoad()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Additive);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
