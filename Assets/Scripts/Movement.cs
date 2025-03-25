using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // A class that can be edited in engine that determines the objects speed
    [SerializeField]
    private float speed = 75f;
    // Reference to an objects RigidBody2D component
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Get the RigidBody2D component of the object
        rb = GetComponent<Rigidbody2D>();
    }

    // Function that moves the object in a direction based on it's specific speed and direction
    public void Move(Vector2 direction)
    {
        // rb.velocity used so there is no acceleration speed up delay
        rb.velocity = direction * speed * Time.deltaTime;
    }
}
