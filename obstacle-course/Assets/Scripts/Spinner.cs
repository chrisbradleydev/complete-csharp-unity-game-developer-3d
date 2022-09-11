using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        float yAngle = Time.deltaTime * rotateSpeed;
        transform.Rotate(0, yAngle, 0);
    }
}
