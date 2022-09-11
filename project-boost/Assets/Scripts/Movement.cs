using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Thrusting");
        }
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Rotating left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Rotating right");
        }
    }
}
