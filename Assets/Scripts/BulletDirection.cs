using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 1;
    private Vector3 shotDirection = Vector3.zero;

    private void Update()
    {
        if(shotDirection != Vector3.zero)
        {
            this.transform.position = this.transform.position + (shotDirection * Time.deltaTime * bulletSpeed);
        }
    }
    public void SetDirection(Vector3 direction)
    {
        shotDirection = direction;
    }


}
