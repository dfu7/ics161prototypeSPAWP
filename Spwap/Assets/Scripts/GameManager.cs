using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Instance
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    instance = new GameObject("Spawned AudioManager", typeof(GameManager)).GetComponent<GameManager>();
                }
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }
    #endregion
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void LevelLoad()
    {
        SceneManager.LoadScene("Level1");
    }
    public void MenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
