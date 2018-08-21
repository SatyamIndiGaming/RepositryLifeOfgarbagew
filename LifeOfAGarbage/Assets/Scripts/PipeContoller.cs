using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeContoller : MonoBehaviour {
    public float speed;

    public float upDownMovement;

   private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody2D>();
        MovePipe();
        InvokeRepeating("DownUpMovment", 0.1f, 1);

	}
	
	// Update is called once per frame
	void Update () {
		





	}

    void MovePipe() {

        rigidbody.velocity = new Vector2(-speed, 0);


    }

    void DownUpMovment(){
        upDownMovement = -upDownMovement;
        rigidbody.velocity = new Vector2(speed, upDownMovement);

    }


}
