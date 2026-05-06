using UnityEngine;

public class EndGame : MonoBehaviour
{

    public void GameOver()
    {
        GetComponent<EnemySpawner>().StopSpawning();
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        MapCleaner(enemies);
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
        MapCleaner(bullets);

        Debug.Log("GameOver");

    }

    private void MapCleaner(GameObject[] toDestroy)
    {
        foreach(GameObject obj in toDestroy)
            Destroy(obj);

    }

}
