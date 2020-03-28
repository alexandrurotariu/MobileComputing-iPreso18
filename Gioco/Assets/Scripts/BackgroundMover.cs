using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public Transform t;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        t.Translate(-speed * Time.deltaTime, 0, 0);

        if(t.transform.position.x < -20.01f)
        {
            t.transform.position = new Vector3(0, 0, 10f);
        }
    }
}
