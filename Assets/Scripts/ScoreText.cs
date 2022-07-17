using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    GameObject currScoreText, highScoreText;

    void Start()
    {
        currScoreText = GameObject.Find("CurrScoreText");
        highScoreText = GameObject.Find("HighScoreText");
    }

    void Update()
    {
        currScoreText.GetComponent<Text>().text = "Current Score: " + GameManager.currScore.ToString();
        highScoreText.GetComponent<Text>().text = "High Score:     " + GameManager.highScore.ToString();
    }
}
