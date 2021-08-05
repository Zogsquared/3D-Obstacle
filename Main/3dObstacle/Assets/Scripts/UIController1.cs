using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController1 : MonoBehaviour {
    public static UIController1 instance;
    public TextMeshProUGUI scoreText;
    public Text highScoreText;
    float time = 0;
    float bestTime = 9999;

    private void Awake(){
        instance = this;
        PlayerPrefs.SetFloat("bestTime", 9999);
    }
    void Start()
    {
        bestTime = PlayerPrefs.GetFloat("bestTime", 0);
        highScoreText.text = "Best Time: " + bestTime.ToString();
        //PlayerPrefs.SetFloat("bestTime", 9999);
        
    }
    public void SetHighScore(float BestScore){
        if(bestTime > BestScore)
        PlayerPrefs.SetFloat("bestTime", BestScore);
    }
    void FixedUpdate(){
        time += 0.2f;
        scoreText.text = "Time: " + time;
    }
}