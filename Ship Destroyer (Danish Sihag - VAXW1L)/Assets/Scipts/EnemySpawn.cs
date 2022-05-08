using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public List<GameObject> enemyShips;

    public GameObject ship;

    Vector3 enemySpawnPosition;

    public void SpawnEnemyShips()
    {
        enemySpawnPosition = new Vector3(Random.Range(-152f, 152f), 2.4f, ship.transform.position.z + 325);
        Instantiate(enemyShips[Random.Range(0, enemyShips.Count)], enemySpawnPosition, enemyShips[Random.Range(0, enemyShips.Count)].transform.rotation);
    }

     public void Start()
    {
        InvokeRepeating("SpawnEnemyShips", 1, 3);
    }


}
