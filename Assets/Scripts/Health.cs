using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float health = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        //Debug.Log($"DAMAGER TAKEN! {health}");
        if(health <= 0)
            Destroy(this.gameObject);

    }
}
