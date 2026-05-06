using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] float damage = 1f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("LANDED! LANDED!");
        if(collision.GetComponent<Health>())
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }


}
