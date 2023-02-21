using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class Player : MonoBehaviour
{
    // Variables for if space key was pressed
    private bool spaceKeyWasPressed;
    // variable for horizontal input
    private float horizontalInput;
    // variable for holding getRigidBody component
    private Rigidbody rigidbodyComponent;



    // Start is called before the first frame update
    void Start()
    {
        // set the rigidbodyComponent to what is returned by getComponent<RigidBody>();
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true) // gets input from spacebar, if pressed do the following
        {
            spaceKeyWasPressed = true;
        }

        // collect horizontal input (by default a, d, left and right on keyboard, default value is 0)
        horizontalInput = Input.GetAxis("Horizontal");
    }

    // Fixed Update is called 100 times per second by default, helps keep physics standard
    private void FixedUpdate()
    {
        // Jump function; detects if player is pressing space, then jumps if they are
        if (spaceKeyWasPressed == true)
        {
            // If Space is pressed, get Rigidbody component from player and add upwards force using
            // ForceMode VelocityChange
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            spaceKeyWasPressed = false;
        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);
    }
}
