using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class BoidSpawner : MonoBehaviour
{
    public Boid objectToSpawn;
    public float spawnSize = 5;
    public Vector3 origin = Vector3.zero;
    public float radius = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnSize; i++)
        {
            Vector2 randomPosition = origin + Random.insideUnitSphere * radius;
            Instantiate(objectToSpawn, randomPosition,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
