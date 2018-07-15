using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text bestScoreText;

    public float scoreCount;
    public float bestScoreCount;


    public float pointsPerSecond;

    public bool scoreIncreasing;


	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScoreCount = PlayerPrefs.GetFloat("BestScore");
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        if(scoreCount > bestScoreCount)
        {
            bestScoreCount = scoreCount;
            PlayerPrefs.SetFloat("BestScore", bestScoreCount);
        }

        scoreText.text = "Score : " + Mathf.Round(scoreCount);
        bestScoreText.text = "Best Score : " + Mathf.Round(bestScoreCount);
    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
