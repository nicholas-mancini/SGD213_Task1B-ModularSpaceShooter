using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    // Class to set what game object is used for bullet
    [SerializeField]
    private GameObject bullet;
    // Float class to determine the time the last bullet was fired
    private float lastTimeFired = 0f;
    // Float class to set the time between when each bullet can be fired
    [SerializeField]
    private float fireDelay = 1f;
    // Float class to set the offset of the bullet transform along an axis
    private float bulletOffset = 2f;

    void Start()
    {
        // Math to spawn bullets in front of the the player
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Render half the player size
        + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size along the y axis
    }

    // Function for the action of shooting
    public void Shoot()
    {
        // Setting the CurrentTime to Time.time
        float CurrentTime = Time.time;

        // If the time between the lastTimeFired is greater than the fireDelay
        // This creates a delay so we don't shoot too many bullets
        if (CurrentTime - lastTimeFired > fireDelay)
        {
            // The spawnPosition is set to a new vector2 equal to the players x location and y location + bulletOffset so it spawn slightly infront 
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

            // Create a bullet at the spawnPosition
            Instantiate(bullet, spawnPosition, transform.rotation);

            // Set the lastTimeFired to the CurrentTime for recalculating this if statement next time
            lastTimeFired = CurrentTime;
        }
    }

    /// <summary>
    /// SampleMethod is a sample of how to use abstraction by
    /// specification. It converts a provided integer to a float.
    /// </summary>
    /// <param name="number">any integer</param>
    /// <returns>the number parameter as a float</returns>
    public float SampleMethod(int number) {
        return number;
    }

}
