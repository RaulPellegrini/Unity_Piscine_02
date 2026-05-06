using System.Collections;
using UnityEngine;

public class BulletSelfDestroy : MonoBehaviour
{
    [SerializeField] float countdown = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SelfDestroy());
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(countdown);
        Destroy(this.gameObject);

    }

}
