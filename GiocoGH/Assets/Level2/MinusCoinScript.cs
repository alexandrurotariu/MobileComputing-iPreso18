using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusCoinScript : MonoBehaviour
{
    public AudioSource suono;
    public AudioClip lungo;

    public Transform moneta;
    public Transform particella;

    void OnTriggerEnter2D(Collider2D col)
    {
        Instantiate(particella, moneta.position, moneta.rotation);
        transform.position = Vector3.one * 9999f;
        suono.Play();
        ScoreTextScript.coinAmount -= 1;
        Destroy(gameObject, lungo.length);
    }
}
