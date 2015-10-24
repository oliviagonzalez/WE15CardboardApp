using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
    private Rigidbody rigidBody;
    private Vector3 startingPosition;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = transform.forward * speed;
    }
	
}
