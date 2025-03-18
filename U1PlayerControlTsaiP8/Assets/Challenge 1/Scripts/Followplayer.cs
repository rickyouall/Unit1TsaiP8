using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public GameObject plane;
    private float horizontalInput;
    private float turnSpeed = 45.0f;


    private Vector3 offset = new Vector3(36, 1, 0);
    private Vector3 offset1 = new Vector3(0, 5, 0);
   // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    { //Offset the camera behind the player by adding to the player's position
        transform.position = plane.transform.position + offset;

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


        if (Input.GetKey(KeyCode.F))
        {
            transform.position = plane.transform.position + offset1;
        }

    }
}

