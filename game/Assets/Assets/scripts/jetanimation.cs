using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetanimation : MonoBehaviour
{
    public Animator anim;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
            
        {
            anim.Play("fly");
            Debug.Log("fly");
            
        }
    }
}
