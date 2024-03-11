using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpanwer : MonoBehaviour
{
    public GameObject[] myObjects;

    [SerializeField] public int rangeX;
    [SerializeField] public int rangeY;
    [SerializeField] public int rangeZ;

    private float spawnInterval;

    void Start()
    {
        Invoke("Spawn", 0.5f);

    }

    void Update()
    {
        

    }

    void Spawn()
    {
        spawnInterval = Random.Range(1f, 15f);

        int randomIndex = Random.Range(0, myObjects.Length);

        Vector3 randomSpawnPosition = new Vector3(Random.Range(rangeX, rangeY), rangeZ, Random.Range(rangeX, rangeY));
        Instantiate(myObjects[randomIndex], this.transform.position + randomSpawnPosition, Quaternion.identity);

        Invoke("Spawn", spawnInterval);
    }
}
