using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // reference Movement.cs
    private Movement movement;
    // reference ShootingScript.cs
    private ShootingScript shooting;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Movement script component of object applied to
        movement = GetComponent<Movement>();
        // Get the ShootingScript script component of object applied to
        shooting = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Setting input to equal the float value of the horizontal axis input left being -1 and right being 1
        float input = Input.GetAxis("Horizontal");

        // Calling the Move function from Movement.cs, setting the direction to right and multiplying it by the float input value
        movement.Move(Vector2.right * input);

        // If the input button for Fire1 is triggered
        if (Input.GetButton("Fire1"))
        {
            // Then execute the Shoot function from ShootingScript.cs
            shooting.Shoot();
        }
    }
}
