using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public static int score;

    private void Awake()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.SetText("Score: " + score.ToString());
    }
}
