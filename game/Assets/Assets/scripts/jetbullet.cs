using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetbullet : MonoBehaviour
{

    private Transform player;
    public float moveSpeed = 5f;
    public ParticleSystem fire;

    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        fire.Play();
    }


}
