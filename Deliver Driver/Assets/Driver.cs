using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float turningSpeed = 100f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

  


    void Update()
    {
        float turningAmount = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-turningAmount);
        transform.Translate(0,moveAmount, 0f);
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Speed up"){
           
           moveSpeed = boostSpeed;

        } 
    }

    void  OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

   
}
