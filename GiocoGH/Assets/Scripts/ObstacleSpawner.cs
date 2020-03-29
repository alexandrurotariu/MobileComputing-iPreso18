using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    private float secondsLeftTillSpawn = 0;
    public float spawnSpeed = 30;
    public float spawnChange;
    public GameObject obstPrefab;

    // Update is called once per frame
    void Update()
    {
        secondsLeftTillSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);

        if(temp <= spawnChange && secondsLeftTillSpawn <= 0)
        {
            Instantiate(obstPrefab, new Vector3(12, Random.Range(-1.65f, -1.65f), 0), Quaternion.identity,transform);
            secondsLeftTillSpawn = spawnSpeed;
        }
    }
}
