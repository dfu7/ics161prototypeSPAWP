using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1Player : MonoBehaviour
{
    void Awake()
    {
        AudioManager.Instance.PlayMusic("VOLTEX");
    }
}
