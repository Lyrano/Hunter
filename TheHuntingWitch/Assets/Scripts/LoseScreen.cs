using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseUI;
    bool hasWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            loseUI.SetActive(true);
            Time.timeScale = 0;
            hasWon = true;
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        //loseUI = GameObject.FindGameObjectWithTag("UI");
        loseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
