using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedControler : MonoBehaviour
{
    // Class to set the movement direction of object applied to
    [SerializeField]
    private Vector2 direction;
    // Reference to Movement.cs
    [SerializeField]
    private Movement movment;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Movement script component of object applied to
        movment = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        // Execute the Move function from Movement.cs in the direction specified above
        movment.Move(direction);
    }
}
