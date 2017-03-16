using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float velocity = 5;
    private Rigidbody rigidbody;
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 vel = rigidbody.velocity;


       rigidbody.velocity = new Vector3(h * velocity, vel.y, v * velocity);

    }
}
