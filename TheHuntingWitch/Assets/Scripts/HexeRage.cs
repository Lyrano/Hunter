using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HexeRage : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Dreissigsec());
    }

    IEnumerator Dreissigsec()
    {
        yield return new WaitForSeconds(30f);
        StartCoroutine(Fuenf());
    }

    IEnumerator Fuenf()
    {
        //Debug.Log("Speed");
        agent.speed = 8f;
        yield return new WaitForSeconds(5f);
        agent.speed = 4f;
        StartCoroutine(Dreissigsec());
    }

}
