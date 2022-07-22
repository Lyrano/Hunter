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

    [SerializeField]
    GameObject[] walls;

    [SerializeField]
    GameObject Pfeil;


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
                itemActive = false;
            }
            if (items[1].activeSelf) 
            {
                Debug.Log("Destroy");
                foreach (GameObject wall in walls)
                {
                    if (wall.activeSelf)
                        
                    {
                        if(wall.GetComponent<DestroyWall>().isCol)
                            wall.SetActive(false);
                        itemActive = false;
                        
                    }

                        
                    
                }
            }
            if (items[2].activeSelf)
            {
                Pfeil.SetActive(true);
            }




                if (itemActive == false)
            ResetItem();
            
        }
    }
    IEnumerator speedboost()
    {
        agent.speed = 9f;
        yield return new WaitForSeconds(10f);
        agent.speed = 6f;
        
        agent.angularSpeed = 300f;
        yield return new WaitForSeconds(10f);
        agent.angularSpeed = 230f;
    }

}
