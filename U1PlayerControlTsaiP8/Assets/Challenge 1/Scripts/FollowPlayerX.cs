using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 7, -12);
    private Vector3 offset1 = new Vector3(0, 4, -6);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset1;


        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = plane.transform.position + offset;
        }
    }
}
