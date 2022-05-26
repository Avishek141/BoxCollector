using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    
    public GameObject enemyPrefab;
    private Vector3 spawnPos;
    // private float spawnPosZ;
    private float startDelay=2.0f;
    private float repeatDelay =1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomSpawnEnemy", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void RandomSpawnEnemy()
    {
         spawnPos=new Vector3(Random.Range(15,-15),0,Random.Range(10,-2));;
         Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }

    

    


}
