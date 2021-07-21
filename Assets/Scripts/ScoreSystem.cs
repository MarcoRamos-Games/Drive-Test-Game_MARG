using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMulitplier;

    public const string HighScoreKey = "HighScore";

    private float score;

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMulitplier;
        int displayScore = Mathf.FloorToInt(score);
        scoreText.text = displayScore.ToString();
    }

    private void OnDestroy()
    {
       int currentHigshScore =  PlayerPrefs.GetInt(HighScoreKey, 0);
       if(score> currentHigshScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
