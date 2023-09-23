using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10.0f;

    void Update()
    {
        boardRotation();
    }

    void boardRotation() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float xInput = verticalInput * rotationSpeed * Time.deltaTime;
        float zInput = -horizontalInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(xInput, 0.0f, zInput );

    }
       
}
