using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle3 : MonoBehaviour
{

    public float secondsLeftTillSpawn;
    public float spawnSpeed;
    public float spawnChange;
    public GameObject obstPrefab;

    // Update is called once per frame
    void Update()
    {
        secondsLeftTillSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);

        if (temp <= spawnChange && secondsLeftTillSpawn <= 0)
        {
            Instantiate(obstPrefab, new Vector3(15, Random.Range(-2.8f, -4f), -2), Quaternion.identity, transform);
            secondsLeftTillSpawn = spawnSpeed;
        }
    }
}
