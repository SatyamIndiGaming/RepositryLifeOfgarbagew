using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUiManager : MonoBehaviour {
    public static LevelUiManager instace; 
    public Text score;
    public GameObject panel;
    public Text highScore;

    private void Awake()
    {
        if(instace == null)
        {

            instace = this;
        }    
    }
    // Use this for initialization
    void Start () {
		
        

	}
	
	// Update is called once per frame
	void Update () {
		
        
      


	}
}
