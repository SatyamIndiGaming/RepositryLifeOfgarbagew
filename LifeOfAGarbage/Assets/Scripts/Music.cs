using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    public static Music instance = null;
    // Singleton
    // Use this for initialization
    private void Awake()
    {
        //Debug.Log("Music player ID Awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
           // Debug.Log("destroyed the gameobject" + gameObject);
        }
        else
        {
            instance = this;
            
            GameObject.DontDestroyOnLoad(gameObject);

        }
    }
    
	
	
}
