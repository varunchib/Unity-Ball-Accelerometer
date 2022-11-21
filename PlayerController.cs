using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    public float Speed;
    private Rigidbody rb;

    
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    private void Update () 
    {
       
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-Input.acceleration.y, 0f, Input.acceleration.x);
        rb.AddForce(movement*Speed);
    }

    

}

  