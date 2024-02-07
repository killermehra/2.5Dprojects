using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.UIElements;

public class movetoplayer : MonoBehaviour
{
    private Transform player;
    public float moveSpeed = 5f;
  
    private void Update()
    {
        transform.Translate(Vector3. left* moveSpeed * Time.deltaTime);
      
    }


}
