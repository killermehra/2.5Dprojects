using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class palyerhealth : MonoBehaviour
{
    public GameObject bgmusic;
    public GameObject player;
    public  Animator anim;
    public GameObject Gameover;
    public AudioSource gameover;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Transform Player;
    private Vector2 startpoint;
    private void Start()
    {
        anim = GetComponent<Animator>();
        Gameover.SetActive(false);
        bgmusic.SetActive(true);
        gameover = GetComponent<AudioSource>();
        startpoint = Player.position;
        
    }

    private void Update()
    {

        Vector2 distance = (Vector2)Player.position - startpoint;
        distance.y = 0f;

        if (distance.x < 0)
        {
            distance.x = 0;
        }


        text.text = distance.x.ToString("0") + "m";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(player,0.6f);
            anim.Play("Death");
            StartCoroutine(Over());
            gameover.Play();
         
        }
    
    }

    IEnumerator Over()
    {
        yield return new WaitForSeconds(0.5f);

        Time.timeScale = 0f;
        Gameover.SetActive(true);
        Debug.Log("over");
        bgmusic.SetActive(false);
    }

   



}

