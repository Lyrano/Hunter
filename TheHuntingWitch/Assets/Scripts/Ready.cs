using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    [SerializeField]
    Transform UIPanel;

    bool isPaused;


    private void Start()
    {
        //UIPanel.gameObject.SetActive(false);
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            Time.timeScale = 1;
        }
    }
}
