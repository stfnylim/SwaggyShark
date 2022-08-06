using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public Transform[] discoSpawnPoints;
    public Transform[] coinSpawnPoints;
    public GameObject[] enemyPrefabs;
    public GameObject discoBall;
    public GameObject coin;
    private GameObject temp;
    private float nextActionTime = 0.0f;
    private float nextDiscoTime = 0.0f;
    private float nextPartyTime = 0.0f;
    public float distance = 15.0f;
    public float period = 2.0f;
    public bool discoTime = false;
    private float currentDistance;

    // Update is called once per frame
    void Start(){
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        int randDiscoPoint = Random.Range(0, discoSpawnPoints.Length);
        int randCoinPoint = Random.Range(0, coinSpawnPoints.Length);

        temp = randomEnemySpawn(randEnemy, randSpawnPoint);

        
    }
    public void setDiscoTime(bool disco){
        discoTime = disco;
       
        

    }
    void FixedUpdate()
    {
        currentDistance = Vector3.Distance(spawnPoints[1].position, temp.transform.position);

        // check if it's ~disco time~ yet

        if(discoTime){
            nextDiscoTime += nextActionTime;
            if(Time.time < period * 10){
                if(Time.time > nextDiscoTime && currentDistance > distance/2  ){
                    nextDiscoTime += period/2;
                    randomCoinSpawn(0);
                    randomCoinSpawn(1);
                    randomCoinSpawn(2);
                }
            }
            else{
                setDiscoTime(false);
            }
        }
        else{

            if(Time.time> nextActionTime && currentDistance > distance ){ // Execute random enemy spawner every period number of seconds
                nextActionTime += period;
                int randEnemy = Random.Range(0, enemyPrefabs.Length);
                int randSpawnPoint = Random.Range(0, spawnPoints.Length);
                int randDiscoPoint = Random.Range(0, discoSpawnPoints.Length);
                int randCoinPoint = Random.Range(0, coinSpawnPoints.Length);  

                if(discoTime && Time.time > nextPartyTime){
                    nextPartyTime += 10* period;
                    //randomCoinSpawn(randSpawnPoint,randCoinPoint);
                }
                else if(discoTime&& Time.time <= nextPartyTime){
                    discoTime = false;
                }
                else{
                    if(randDiscoPoint != 0 && randSpawnPoint == 0 && randCoinPoint == 0|| randSpawnPoint != 0 && randDiscoPoint == 0 && randCoinPoint != 0){
                        randomDiscoSpawn(randDiscoPoint);
                    }
                    temp = randomEnemySpawn(randEnemy, randSpawnPoint);

                    if(randSpawnPoint != randCoinPoint){
                        randomCoinSpawn(randCoinPoint);
                    }
                    currentDistance = Vector3.Distance(spawnPoints[randSpawnPoint].position, temp.transform.position);
                    //Debug.Log("The distance is : " + currentDistance);

                }
                

            }
        }
        
    }

    void randomDiscoSpawn(int randDiscoPoint){
        // every 10 enemy spawn, there is a discoball spawn
        if(Time.time > nextDiscoTime){
            nextDiscoTime += 10*period;
            Instantiate(discoBall, discoSpawnPoints[randDiscoPoint].position, transform.rotation);
        }
    }
    GameObject randomEnemySpawn(int randEnemy, int randSpawnPoint){
       
            if(randSpawnPoint == 0){ // Jellyfish spawns on top
                return Instantiate(enemyPrefabs[1], spawnPoints[randSpawnPoint].position, transform.rotation);

            }
            else if(randSpawnPoint == 1){
                return Instantiate(enemyPrefabs[1], spawnPoints[randSpawnPoint].position, transform.rotation);
            }
            else{  
                return Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
            }
    }
    /**
    method will cause all enemy spawns to turn into discos for n number of enemy spawns
    */
    void randomCoinSpawn(int randCoinPoint){
        Instantiate(coin, coinSpawnPoints[randCoinPoint].position, transform.rotation);
    }



}
