using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float turnSpeed = 45.0f;
    private float speed = 20.0f;
    private float forwardinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
      forwardinput = Input.GetAxis("Vertical");
       
        

        //We'll move the vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardinput);
        //Rotates the car based on the horizontal input.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed* horizontalInput);

    }
}
