using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankgun : MonoBehaviour
{
    public Transform gunBarrel;
    public GameObject bulletPrefab;
    public float fireRate = 0.2f;
    private float nextFireTime;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time >= nextFireTime)
            {



                Shoot();

            }
        
        
    }
    void Shoot()
    {

        nextFireTime = Time.time + fireRate;


        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);


        Bullet bulletScript = bullet.GetComponent<Bullet>();




    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("bullet"))
        {
            Destroy(gameObject);
        }
    }
}
