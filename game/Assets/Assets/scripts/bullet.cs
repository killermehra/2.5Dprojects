using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;

    public float life;
  



    void Update()
    {

        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);

        Destroy(gameObject, life);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("enemy"))
        {
            Destroy(gameObject);
        }
    }


}
