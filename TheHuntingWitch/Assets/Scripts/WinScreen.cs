using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject wonUI;
    bool hasWon = false;

    void OnTriggerEnter(Collider other)
    {
        wonUI.SetActive(true);
        if(other.tag == "Player")
            hasWon = true;
        Time.timeScale = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        wonUI.SetActive(false);
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
