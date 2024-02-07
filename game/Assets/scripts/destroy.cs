using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
   
    public GameObject explosion;
    //public float cliplength = 1f;
    //public GameObject Audiosource;
    public AudioSource sound;
    private void Start()
    {
        // Audiosource.SetActive(false);
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other .gameObject.tag == ("bullet") )
        {
          
            Debug.Log("death");
            Destroy(gameObject,0.1f);
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            sound.Play();
            
        }
      
    }
 
}


