using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Score : MonoBehaviour
{
    public static int score;

    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.SetText("Score: " + score.ToString());
    }
}
