using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class Score : MonoBehaviour
{

    
    public int score;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = score.ToString(); // To make sure the score text is accurate
    }

    public void IncreaseScore()
    {
        
        score++;
    }
}