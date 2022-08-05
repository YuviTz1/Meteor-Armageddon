using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreManager : MonoBehaviour
{

   

    Text highScoreText;


    private void Awake()
    {

        highScoreText = GetComponent<Text>();
       

    }

    // Start is called before the first frame update
    void Start()
    {
        
        
        if (scoreManager.score >= PlayerPrefs.GetInt("HIGHSCORE"))
        {
            //highScore = scoreManager.score;
            PlayerPrefs.SetInt("HIGHSCORE", scoreManager.score);
            //highScoreText.text = "High Score = " + highScore.ToString();
        }
        highScoreText.text = "High Score = " + PlayerPrefs.GetInt("HIGHSCORE").ToString();
    }

    private void Update()
    {
        highScoreText.text = "High Score = " + PlayerPrefs.GetInt("HIGHSCORE").ToString();
    }


}
