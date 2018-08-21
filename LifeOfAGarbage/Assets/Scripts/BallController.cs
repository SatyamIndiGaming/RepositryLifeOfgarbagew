using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public float upWardForce;

    public AudioClip clip;

    private Rigidbody2D rigidbody;

    private bool isStarted;

    bool gameOver;

    public float rotation;


    public GameObject tapImage;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        rigidbody = GetComponent<Rigidbody2D>();
        gameOver = false;
        isStarted = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isStarted)
        {
            if (Input.GetMouseButtonDown(0)){
                isStarted = true;
                rigidbody.isKinematic = false;
                tapImage.SetActive(false);
            }
        }
        else if(isStarted && !gameOver) {
            transform.Rotate(0, 0, rotation);
            if (Input.GetMouseButtonDown(0)){
                rigidbody.velocity = Vector2.zero;
                rigidbody.AddForce(new Vector2(0, upWardForce), ForceMode2D.Impulse);

            }

        }
	}
    private void OnTriggerEnter2D(Collider2D collision){

        if(collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "OutTriggers"  ){

            gameOver = true;
            Time.timeScale = 0;
            LevelUiManager.instace.highScore.text ="High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
            LevelUiManager.instace.panel.SetActive(true);


        }
        if(collision.gameObject.tag == "ScoreCheckerTag" && !gameOver){
            
            ScoreManager.instance.IncrementScore();
            LevelUiManager.instace.score.text = PlayerPrefs.GetInt("Score").ToString();
            AudioSource.PlayClipAtPoint(clip, collision.transform.position,0.6f);
        }

        
    }

    //IEnumerator TimeSclaing()
    //{

    //    yield return new WaitForSeconds(0.5f);
    //    Time.timeScale = 0;
    //}

}
