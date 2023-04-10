using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    // Variables for if space key was pressed
    private bool spaceKeyWasPressed;
    // variable for horizontal input
    private float horizontalInput;
    // variable for holding getRigidBody component
    private Rigidbody rigidbodyComponent;
    // field for exposing ground check transform to unity editor
    [SerializeField] private Transform groundCheckTransform;
    // create a layerMask variable for the playerLayer which is called playerMask, exposed variable in Unity editor
    [SerializeField] private LayerMask playerMask;

    // Start is called before the first frame update
    void Start()
    {
        // set the rigidbodyComponent to what is returned by getComponent<RigidBody>();
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // collect horizontal input (by default a, d, left and right on keyboard, default value is 0)
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) == true) // gets input from spacebar, if pressed player will jump
        {
            spaceKeyWasPressed = true;
        }
    }

    // Fixed Update is called 100 times per second by default, helps keep physics standard
    private void FixedUpdate()
    {
        
        // makes horizontal movement possible, using a and d for left and right by default
        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);

        // checks for player collision with the ground using Physics.OverlapSphere
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        

        // Jump function; detects if player is pressing space, then jumps if they are
        if (spaceKeyWasPressed == true)
        {
            // If Space is pressed, get Rigidbody component from player and add upwards force using
            // ForceMode VelocityChange
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            spaceKeyWasPressed = false;
        }
    }

    
}
