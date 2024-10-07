using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
    private float topBound = 20;
    private float lowerBound = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For destroying bullets past the wall
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // For destroying enemy and player and logging game over when enemy passes player
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            
        }
    }
}
