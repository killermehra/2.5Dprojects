using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankbullet : MonoBehaviour
{
    public float bulletSpeed = 10f;

    public float life;

    public ParticleSystem explose;


    void Update()
    {

        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);

        Destroy(gameObject, life);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("level"))
       {
            Destroy(gameObject);
            explose.Play();
            Debug.Log("explose");
        }

        else if (collision.gameObject.CompareTag("PLayer"))
        {
            Destroy(gameObject);
            
            Debug.Log("explosel");
        }
           
        
    }

}
