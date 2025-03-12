using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float turnSpeed =55.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
        //We'll move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        horizontalInput = Input.GetAxis("Horizontal");

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");


        //Rotates the plane based on the horizontal input.
        transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * verticalInput);
        //Rotates the plane based on the vertical input.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
