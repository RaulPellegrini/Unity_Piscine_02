using UnityEngine;

public class CastleDestoyed : MonoBehaviour
{
    void OnDestroy()
    {
        GetComponentInParent<EndGame>().GameOver();
    }
}
