using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEvent

public class PlayerTP : MonoBehaviour
{
    public GameObject tpUI;
    public GameObject objToTP;
    public GameObject tpLoc;

    bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        tpUI.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        tpUI.SetActive(true);
        if ((other.tag == "Player"))
        {
            triggered = true;
        }

    }

    public void TeleportUI()
    {
        objToTP.transform.position = tpLoc.transform.position;
        objToTP.GetComponent<NavMeshAgent>().Warp(tpLoc.transform.position);
    }

    void OnTriggerExit()
    {
        tpUI.SetActive(false);
        
        
            triggered = false;
        
    }

}
