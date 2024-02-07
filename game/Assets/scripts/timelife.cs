using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timelife : MonoBehaviour
{
    public float life;
    bool hasDestroy;
   
   

    private void Start()
    {
       
        
    }
    void Update()
    {
        if (!hasDestroy)
        {
            Destroy(gameObject, life);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag( "bullet"))
        {
            Destroy(gameObject);
            Debug.Log("destroy");
          

        }
    }
  
}
