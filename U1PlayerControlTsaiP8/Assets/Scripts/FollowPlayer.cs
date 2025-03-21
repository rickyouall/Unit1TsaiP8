using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private float horizontalInput;
    private float turnSpeed = 45.0f;


    private Vector3 offset = new Vector3(0, 7, -9);
    private Vector3 offset1 = new Vector3(0, 5, 0);
    private Vector3 offset2 = new Vector3(0, 3, 3);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    { //Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = player.transform.position + offset1;
        }

        else if (Input.GetKey(KeyCode.F))
        {
            transform.position = player.transform.position + offset2;
        }
    }
}
