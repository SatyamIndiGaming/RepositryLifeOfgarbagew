using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawneer : MonoBehaviour {

    public GameObject pipeSlot;

     float minY = 0;

    public float maxY;

    public float spawnTimmer;


	// Use this for initialization
	void Start () {
        StartSpawnningPipe();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public  void StopSpawnningPipe()
    {

        CancelInvoke("PiperSpawnner");
    }

    void StartSpawnningPipe()
    {
        InvokeRepeating("PiperSpawnner", 1, spawnTimmer);

    }


    void PiperSpawnner(){


        Instantiate(pipeSlot, new Vector3(transform.position.x, Random.Range(minY, maxY),0),Quaternion.identity);

    }
}
