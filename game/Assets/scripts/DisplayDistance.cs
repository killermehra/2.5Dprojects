using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDistance : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Transform player;
    private Vector2 startpoint;
    private void Start()
    {
        startpoint = player.position;

    }
    private void Update()
    {
        Vector2 distance = (Vector2)player.position - startpoint;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }
      
        
         text.text = distance.x.ToString("0") + "m";
        
    }
}
