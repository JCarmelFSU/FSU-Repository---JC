using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShots : MonoBehaviour
{
    private float startDelay = 0.5f;
    private float shootInterval = 1;
    public GameObject shotPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", startDelay, shootInterval);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnBullet()
    {
        Vector3 bulletSpawn = new Vector3(transform.position.x, transform.position.y, (transform.position.z - 1));
        Instantiate(shotPrefab, bulletSpawn, transform.rotation);
    }
}
