using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gunfire : MonoBehaviour
{

    public float cliplength = 1f;
        public GameObject Audiosource;
    public Transform gunBarrel;
    public GameObject bulletPrefab;
    public float fireRate = 0.2f;
    
    public Joystick joystick;
  
    private float nextFireTime;
    public AudioSource fire;



    private void Start()
    {
        //Audiosource.SetActive(false);
        fire = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (joystick.Horizontal >= .5f && Time.time > nextFireTime )
        {
            Shoot();
            fire.Play();
        }
        
        if (joystick .Vertical >= 0.5f && Time.time > nextFireTime )
        {
            Shoot();
            fire.Play();


        }
        else if (joystick.Vertical <= -0.5f && Time.time > nextFireTime )
        {
            Shoot();
            fire.Play();
        }

       

    }

    
    void Shoot()
    {
      
        nextFireTime = Time.time + fireRate;

       
        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);

        
        Bullet bulletScript = bullet.GetComponent<Bullet>();

        
       
    }
  //  IEnumerator Gunsound()

 //   {
    //    Audiosource.SetActive(true);
    //    yield return new WaitForSeconds(cliplength);
    //    Audiosource.SetActive(false);

  //  }
  
   
}