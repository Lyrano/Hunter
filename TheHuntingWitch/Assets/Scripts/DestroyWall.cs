using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public bool isCol;
    public Collider Collider;

    private void Start()
    {
        isCol = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            isCol = true;
        if (other.tag == "Enemy")
            Collider.enabled = false;

    }

    void OnTriggerExit(Collider other)
    {
        isCol = false;
        Collider.enabled = true;
    }

}
