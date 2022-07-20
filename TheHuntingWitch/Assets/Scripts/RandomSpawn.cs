using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject witch;


    private Vector3 respawnLocation;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }


    // Start is called before the first frame update
    void Start()
    {


        respawnLocation = witch.transform.position;

        witch = (GameObject)Resources.Load("WitchRunning", typeof(GameObject));

        SpawnWitch();
    }

    private void SpawnWitch()
    {

        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(witch, spawnLocations[spawn].transform.position, Quaternion.identity);

    }
}
