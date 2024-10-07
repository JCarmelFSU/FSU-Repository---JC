using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 15.0f;
    public GameObject bulletPrefab;
    private float xRange = 19;
    private Rigidbody playerRb;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
       
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            Vector3 bulletSpawn = new Vector3(transform.position.x, transform.position.y, (transform.position.z + 1.5f));
            Instantiate(bulletPrefab, bulletSpawn, bulletPrefab.transform.rotation);
                }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            
        }
     
}
}
