using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == ("bullet"))
        {
            Destroy(gameObject);
        }
    }
}
