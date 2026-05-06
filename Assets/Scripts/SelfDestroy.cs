using System.Collections;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    [SerializeField] float countdown = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SelfDestroyCoutdown());
    }

    IEnumerator SelfDestroyCoutdown()
    {
        yield return new WaitForSeconds(countdown);
        Destroy(this.gameObject);

    }

}
