using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roller : MonoBehaviour
{
    private Transform player;
    public float moveSpeed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

}
