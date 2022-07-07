using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawn;
    private float currentSpawn;
    private float spawnInterval = 0.5f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float spawnDifference = lastSpawn - currentSpawn;
        lastSpawn = Time.time;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnDifference > spawnInterval)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            currentSpawn = Time.time;
        }
    }
}
