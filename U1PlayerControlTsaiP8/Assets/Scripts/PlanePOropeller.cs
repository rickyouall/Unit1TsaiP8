using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePOropeller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, 20.0f);

        if (Input.GetKey(KeyCode.Space))
        {

            transform.Rotate(0.0f, 0.0f, -18.0f);
        }

    }
 
}
