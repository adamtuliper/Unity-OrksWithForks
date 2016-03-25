using UnityEngine;
using System.Collections;

public class SimplePlayer : MonoBehaviour {


    //The read in values from the keyboard
    private float _horizontal;
    private float _vertical;

    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Use this for initialization
    void Start () {
        _rigidBody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        //TODO Read Horizontal and Vertical input

        //TODO Read Input.GetButtonDown
    }

    void FixedUpdate()
    {
       //TODO set the rigidbody's velocity
    }
}
