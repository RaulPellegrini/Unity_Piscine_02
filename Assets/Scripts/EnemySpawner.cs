
using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyToSpawn;
    [SerializeField] GameObject locationToSpawn;
    private Vector3 spawnLocation;
    [SerializeField] float respawCooldown = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnLocation = locationToSpawn.transform.position;
        EnemySpawn();
    }


    private void EnemySpawn()
    {
        Instantiate(enemyToSpawn,spawnLocation, Quaternion.identity);
        StartCoroutine(WaitToSpawn());
    }


    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(respawCooldown);
        EnemySpawn();
    }



}
