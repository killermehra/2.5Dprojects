using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject bgmusic;
    public GameObject loadscreem;
    public GameObject mainmusic;
   
    void Start()
    {
        bgmusic.SetActive(true);
        pauseMenu.SetActive(false);
        loadscreem.SetActive(false);
        mainmusic.SetActive(true);
    }

   
    void Update()
    {

    }
    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        bgmusic.SetActive(false);



    }
    public void resumeGame()
    {
        
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        bgmusic.SetActive(true);
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Restart()
    {
       
      // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Play()
    {
        loadscreem.SetActive(true);
        StartCoroutine(Load());
        mainmusic.SetActive(false);
    }
    IEnumerator Load()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;     
    }
    
}
