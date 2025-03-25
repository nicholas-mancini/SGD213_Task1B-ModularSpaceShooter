using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedControler : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private Movement movment;

    // Start is called before the first frame update
    void Start()
    {
        movment = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        movment.Move(direction);
    }
}
