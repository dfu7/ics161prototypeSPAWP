using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMPlayer : MonoBehaviour
{
    void Awake()
    {
        AudioManager.Instance.PlayMusic("NEXTA");
    }
    
}
