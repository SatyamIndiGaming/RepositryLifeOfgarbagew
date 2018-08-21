using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;
    int score;


    // Use this for initialization
    private void Awake(){
        if(instance == null){

            instance = this;

        }
    }
    void Start () {
        PlayerPrefs.SetInt("Score", 0);
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void IncrementScore() {
        score++;
        //Debug.Log(score);
        PlayerPrefs.SetInt("Score", score);
        if (PlayerPrefs.HasKey("HighScore")){
            if (score > PlayerPrefs.GetInt("HighScore")) {

                PlayerPrefs.SetInt("HighScore", score);
            }
        }
        else{

            PlayerPrefs.SetInt("HighScore", score);
        }
    }

}
