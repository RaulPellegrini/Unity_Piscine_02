using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed = 1;

    private Vector3 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.down * speed * Time.deltaTime;
        transform.position = transform.position + movement;
    }


}
