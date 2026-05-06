using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] float damage = 0.1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("LANDED! LANDED!");
        if(collision.GetComponent<EnemyHealth>())
        {
            collision.GetComponent<EnemyHealth>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }


}
