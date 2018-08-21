using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class UnityAds : MonoBehaviour {
    // a static instance available from anywhere to any class 

    public static UnityAds instance;
    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            // the current instanc of the class
            instance = this;
        }
        else
        {
            // destroy the current gameobject
            Destroy(this.gameObject);

        }

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // show ads 

    public void ShowAds()
    {
        if (Advertisement.IsReady("video"))
        {

            Advertisement.Show("video");

        }


    }
}
