using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ItemButton : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject[] items;

    NavMeshAgent agent;
   
    int index;
    public bool itemActive;

    void ResetItem()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }
    }

    public void SetItem(int i)
    {
        ResetItem();
        index = i;
        itemActive = true;
        items[i].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = player.GetComponent<NavMeshAgent>();
        itemActive = false;
        ResetItem();
    }

    public void UseItem()
    {
        if (itemActive)
        {
            if (items[0].activeSelf)
            {
                StartCoroutine(speedboost());
            }
            ResetItem();
            itemActive = false; 
        }
    }
    IEnumerator speedboost()
    {
        agent.speed = 12f;
        yield return new WaitForSeconds(10f);
        agent.speed = 6f;
    }

}
