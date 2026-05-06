using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TurretAI : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 1f;
    [SerializeField] GameObject bulletSpawnLocation;
    private Vector3 bulletLocation;
    private Vector3 shottingDirection;

    private List<GameObject> enemiesInRange = new List<GameObject>();

    void Start()
    {
        bulletLocation = bulletSpawnLocation.transform.position;
    }

    private void shot() // you stopped here
    {
        // if(enemiesInRange != Empty<>)
        // {
            
        // }
        shottingDirection = TargetEnemy().transform.position - this.transform.position;
        shottingDirection.Normalize();
        Instantiate(bullet, bulletLocation, Quaternion.identity);
        StartCoroutine(FireCooldown());
    }

    private GameObject TargetEnemy()
    {
        GameObject targetEnemy = null;
        float closestEnemyDistance = Mathf.Infinity;

        foreach(GameObject enemy in enemiesInRange)
        {
            float distance = Vector3.Distance(enemy.transform.position, this.transform.position);
            if(distance < closestEnemyDistance)
            {
                closestEnemyDistance = distance;
                targetEnemy = enemy;
            }
            
        }

        return(targetEnemy);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
            enemiesInRange.Add(collision.gameObject);

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
            enemiesInRange.Remove(collision.gameObject);
    }

    IEnumerator FireCooldown()
    {
        yield return new WaitForSeconds(fireRate);
        shot();
    }
}
