using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    // Declaring variables 
    [SerializeField] float steerSpeed = 10f; 
    [SerializeField] float moveSpeed = 1f; 


    void Start()
    {
        
    }

    
    void Update()
    {   
        // add Time.delaTime to make frame rate independant -> slow and fast computer both perform the same 
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // Rotation
       transform.Rotate(0, 0, -steerAmount);
       // Move forward
       transform.Translate(0, moveAmount, 0);
    }
}
